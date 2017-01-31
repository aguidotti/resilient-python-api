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
    ///  Represents a type object in the system. This includes built-in types such as "incident" and "task", as well as custom types (Data Table)
    /// </summary>
    public class TypeDto
    {

        /// <summary>
        ///  The internal ID of the type.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The internal type id of the type. For built-in types, the type id maps to the same value as the internal ID. For custom types (Data Table), the type id is mapped one-to-many and have internal IDs >= 1000 0 = INCIDENT 1 = TASK 2 = NOTE 3 = MILESTONE 4 = ARTIFACT 5 = ATTACHMENT 6 = ACTIONINVOCATION 7 = ORGANIZATION 8 = DATATABLE
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        /// <summary>
        ///  The name of the type.  For example, "incident" or "task".
        /// </summary>
        [JsonProperty("type_name")]
        public string TypeName { get; set; }

        /// <summary>
        ///  The fields supported for the type.
        /// </summary>
        [JsonProperty("fields")]
        public Dictionary<string, FieldDefDto> Fields { get; set; }

        /// <summary>
        ///  Additional properties for the type.
        /// </summary>
        [JsonProperty("properties")]
        public TypePropertiesDto Properties { get; set; }

        /// <summary>
        ///  The list of names of parent types. For example, the parent type of "artifact" would be "incident". In the case of notes and attachments, the parent_types will contain both "task" and "incident". The parent type of a Data Table is "incident". This value is read-only except on create.
        /// </summary>
        [JsonProperty("parent_types")]
        public List<string> ParentTypes { get; set; }

        /// <summary>
        ///  The display name for the type.
        /// </summary>
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        ///  True if a notification can be created for this type, false otherwise.
        /// </summary>
        [JsonProperty("for_notifications")]
        public bool ForNotifications { get; set; }

        /// <summary>
        ///  True if an action can specify this type, false otherwise.
        /// </summary>
        [JsonProperty("for_actions")]
        public bool ForActions { get; set; }

        /// <summary>
        ///  True if a custom field can be created for this type, false otherwise.
        /// </summary>
        [JsonProperty("for_custom_fields")]
        public bool ForCustomFields { get; set; }

        /// <summary>
        ///  This value is used for export/import to uniquely represent this type
        /// </summary>
        [JsonProperty("export_key")]
        public string ExportKey { get; set; }

        /// <summary>
        ///  The UUID for this type
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        ///  The list of actionsdefined for this type
        /// </summary>
        [JsonProperty("actions")]
        public List<PartialActionDto> Actions { get; set; }

    }
}
