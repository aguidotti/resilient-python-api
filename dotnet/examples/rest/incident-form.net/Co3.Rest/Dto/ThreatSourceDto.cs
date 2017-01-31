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
    /// </summary>
    public class ThreatSourceDto
    {

        /// <summary>
        ///  The threat source's id
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The threat source's display name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  Brief description of the threat source
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        ///  Indicates if the threat source is enabled (true) for this org
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        ///  Indicates if the threat source is a custom (non-system) threat source
        /// </summary>
        [JsonProperty("custom")]
        public bool Custom { get; set; }

        /// <summary>
        ///  The date on which the terms of service for this threat service was agreed to
        /// </summary>
        [JsonProperty("tos_agreement_date")]
        public DateTime TosAgreementDate { get; set; }

        /// <summary>
        ///  True if the license must be agreed to before this threat source can be enabled
        /// </summary>
        [JsonProperty("prompt_license")]
        public bool PromptLicense { get; set; }

        /// <summary>
        ///  Returns the API license for this threat source
        /// </summary>
        [JsonProperty("license")]
        public string License { get; set; }

        /// <summary>
        ///  The threat source's properties
        /// </summary>
        [JsonProperty("properties")]
        public Dictionary<string, string> Properties { get; set; }

        /// <summary>
        ///  An object describing the terms of service data that need to be collected before this threat service can be turned on
        /// </summary>
        [JsonProperty("tos")]
        public ThreatSourceTosDto Tos { get; set; }

    }
}
