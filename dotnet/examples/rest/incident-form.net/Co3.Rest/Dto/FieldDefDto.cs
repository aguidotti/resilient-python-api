﻿/*
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
using System.ComponentModel;

namespace Co3.Rest.Dto
{
    /// <summary>
    ///  Represents a field definition in the system.
    /// </summary>
    public class FieldDefDto : PartialFieldDefDto
    {

        /// <summary>
        ///  The internal ID of the type. This field is read-only.
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        ///  The tooltip to display next to the field (i.e. the popup text to display when the user hovers over the "i" icon).
        /// </summary>
        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }

        /// <summary>
        ///  The placeholder to display in the edit field (not applicable for all input types).
        /// </summary>
        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        ///  The input type for this field (e.g. "select", "multiselect", "text", etc.).  For a list of valid input types, see constDTO input_types.
        /// </summary>
        [JsonProperty("input_type")]
        public InputType InputType { get; set; }

        /// <summary>
        ///  The required status of the field.  Valid values: "always" - a value is always required, even when initially creating the object. "close" - a value is required before the object (incident) can be closed.  The Co3 UI will prompt the user on close if a value is not available. null - a value is optional
        /// </summary>
        [JsonProperty("required")]
        [DefaultValue(FieldRequired.Optional)]
        public FieldRequired Required { get; set; }

        /// <summary>
        ///  The field should be hidden from the list of fields allowed in notification trigger conditions.  Generally this should be false for custom fields.
        /// </summary>
        [JsonProperty("hide_notification")]
        public bool HideNotification { get; set; }

        /// <summary>
        ///  Is the field a "chosen" field?  This appears in the Co3 UI as "Advanced UI".  It is valid only for select and multiselect fields.  It's best to enable this option when there will be several values to choose from. This option allows the user to search the list for a certain value, and is more visually appealing for longer lists and multiselects."}
        /// </summary>
        [JsonProperty("chosen")]
        public bool Chosen { get; set; }

        /// <summary>
        ///  Should a blank option be selectable in the UI?  Enable this option if you'd like users to have the option of leaving the field blank.
        /// </summary>
        [JsonProperty("blank_option")]
        public bool BlankOption { get; set; }

        /// <summary>
        ///  Is this field an internal Co3 field?  This value is read-only.
        /// </summary>
        [JsonProperty("internal")]
        public bool Internal { get; set; }

        /// <summary>
        ///  The set of valid condition operations for this field.  These are the conditions that can appear in the notification or action triggers section.  This value is read-only.
        /// </summary>
        [JsonProperty("operations")]
        public List<MethodName> Operations { get; set; }

        /// <summary>
        ///  The possible values for this field.  This is only applicable for select and multiselect fields.
        /// </summary>
        [JsonProperty("values")]
        public List<FieldDefValueDto> Values { get; set; }

        /// <summary>
        ///  The UUID of this field.  This value is read-only.  The server sets this value when the field is initially created.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        ///  The permissions the caller has on this field. This value is read-only. This value is set based on the permissions of the caller. See FieldDefPermsDTO.
        /// </summary>
        [JsonProperty("perms")]
        public FieldDefPermsDto Perms { get; set; }

        /// <summary>
        ///  True if this is a read-only field, false otherwise.
        /// </summary>
        [JsonProperty("read_only")]
        public bool ReadOnly { get; set; }

        /// <summary>
        ///  The "permissions" for the individual condition methods.
        /// </summary>
        [JsonProperty("operation_perms")]
        public Dictionary<string, MethodNamePermsDto> OperationPerms { get; set; }

        /// <summary>
        ///  Can the field values ever change?  For example, the incident create_date field cannot ever change so changeable will be false for that field.
        /// </summary>
        [JsonProperty("changeable")]
        public bool Changeable { get; set; }

        /// <summary>
        ///  The label for a boolean false value. Default is "No" and is currently read-only.
        /// </summary>
        [JsonProperty("label_false")]
        public string LabelFalse { get; set; }

        /// <summary>
        ///  The label for a boolean true value. Default is "Yes" and is currently read-only.
        /// </summary>
        [JsonProperty("label_true")]
        public string LabelTrue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("rich_text")]
        public bool RichText { get; set; }

        /// <summary>
        ///  This value is used for export/import to uniquely represent this field
        /// </summary>
        [JsonProperty("export_key")]
        public string ExportKey { get; set; }

        /// <summary>
        ///  The order of this column in the table (1 = leftmost)
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        ///  The width of this column
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
