/*
 * Resilient Systems, Inc. ("Resilient") is willing to license software
 * or access to software to the company or entity that will be using or
 * accessing the software and documentation and that you represent as
 * an employee or authorized agent ("you" or "your") only on the condition
 * that you accept all of the terms of this license agreement.
 *
 * The software and documentation within Resilient's Development Kit are
 * copyrighted by and contain confidential information of Resilient. By
 * accessing and/or using this software and documentation, you agree that
 * while you may make derivative works of them, you:
 *
 * 1)  will not use the software and documentation or any derivative
 *     works for anything but your internal business purposes in
 *     conjunction your licensed used of Resilient's software, nor
 * 2)  provide or disclose the software and documentation or any
 *     derivative works to any third party.
 *
 * THIS SOFTWARE AND DOCUMENTATION IS PROVIDED "AS IS" AND ANY EXPRESS
 * OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL RESILIENT BE LIABLE FOR ANY DIRECT,
 * INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)
 * HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT,
 * STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
 * OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Co3.Rest.Dto
{
    /// <summary>
    ///  Represents text content (e.g. incident description, incident resolution summary, artifact description, etc.). The Resilient server will accept either a JSON string or an object of the form: { "format": "html|text", "content": "content text or HTML (depending on format)" } If you send a string, you must be aware of the "rich_text" setting on the field you're sending. If sending an object, you can supply content in either "text" or "html" format.  The server will make a best effort to convert the content into the format needed to display the field in the UI. On output (e.g. the return from a GET, PUT or POST), the textContentDTO is written as a JSON string by default.  The content of the string object will depend on the "rich_text" property of the field.  So if "rich_text" is true, then the content will be HTML.  If "rich_text" is false, then the content will be in plain text.  Note that it is technically possible for the content to be stored on the server in plain text for fields that are marked as rich text (or vice-versa).  When the server is in the default mode, it will convert the data to the format specified in the field definition and write it out as a JSON string.  For example, if the content on the server is plain text but the field definition is "rich text", then the server will perform a plain text to HTML conversion.  The reverse can occur too, for example if an API program sends HTML but the field definition is not rich text then the server will perform a best effort at an HTML to plain text conversion. An API client can request that data be sent in whatever format it is in on the server by specifying the "text_content_output_format=objects_no_convert" query string or HTTP header.  In this case, the server will send the full object. An API client can also request that data be sent as an object, but have conversion applied by specifying the "text_content_output_format=objects_convert" query string or HTTP header.  In this case, the server will send the full object and convert to the format specified in the field definition (if "rich_text" is true then the format will always be returned as "html" and if it's false then it'll always be returned as "text"). An API client can also ask for data in either HTML or text format specifically (regardless of the field definition and the format in which the data is stored) by using either the text_content_output_format=objects_html or text_content_output_format=objects_text request query string or HTTP header.
    /// </summary>
    public class TextContentDto
    {

        /// <summary>
        ///  The format of the text content.
        /// </summary>
        [JsonProperty("format")]
        public TextFormat Format { get; set; }

        /// <summary>
        ///  The actual text content.  This can be either HTML or plain text depending on the value of the format property.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

    }
}
