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
    ///  An automatic task template that gets instantiated when incidents are created or updated.
    /// </summary>
    public class AutomaticTaskDto
    {

        /// <summary>
        ///  The ID of the automatic task.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The name of the automatic task.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  Is the automatic task to be an optional task when instantiated?
        /// </summary>
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        /// <summary>
        ///  The units for the due date.  Allowed values:  "days", "months", "years".
        /// </summary>
        [JsonProperty("due_date_units")]
        public string DueDateUnits { get; set; }

        /// <summary>
        ///  The number of units.  If dueDateUnits is "days" then a value of one in this field means that the task is to be due "1 day" after it was discovered.
        /// </summary>
        [JsonProperty("due_date_offset")]
        public int DueDateOffset { get; set; }

        /// <summary>
        ///  The instructions for the task.  This should generally be HTML, although it will be cleansed to remove possible cross site scripting issues.
        /// </summary>
        [JsonProperty("instructions")]
        public string Instructions { get; set; }

        /// <summary>
        ///  Is the automatic task enabled?
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        ///  The list of incident types for which this automatic task is to be instantiated.  The automatic task will be instantiated for incidents who have any of these incident types.  See also fullOrgDTO.incident_types (contains a list of all incident type IDs and their corresponding names).
        /// </summary>
        [JsonProperty("incident_types")]
        public List<ObjectHandle> IncidentTypes { get; set; }

        /// <summary>
        ///  The phase this automatic task belongs to
        /// </summary>
        [JsonProperty("phase_id")]
        public ObjectHandle PhaseId { get; set; }

        /// <summary>
        ///  The category this automatic task belongs to.
        /// </summary>
        [JsonProperty("category_id")]
        public ObjectHandle CategoryId { get; set; }

        /// <summary>
        ///  A unique identifier for the automatic task.
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty("export_key")]
        public string ExportKey { get; set; }

    }
}
