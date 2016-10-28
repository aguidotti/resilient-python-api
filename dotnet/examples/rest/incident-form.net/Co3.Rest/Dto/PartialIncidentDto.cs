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
    ///  This object contains a minimal subset of the incident data.  It is useful for displaying in a list.
    /// </summary>
    public class PartialIncidentDto
    {

        /// <summary>
        ///  The incident ID.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The name of the incident.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  The date the incident was discovered.  This is a required field and has significant implications for privacy-related incidents.  Many of the tasks that get generated will have their due dates set based on this date.
        /// </summary>
        [JsonProperty("discovered_date")]
        public DateTime DiscoveredDate { get; set; }

        /// <summary>
        ///  The earliest due date of any incident task.
        /// </summary>
        [JsonProperty("due_date")]
        public DateTime DueDate { get; set; }

        /// <summary>
        ///  The date the incident was created.
        /// </summary>
        [JsonProperty("create_date")]
        public DateTime CreateDate { get; set; }

        /// <summary>
        ///  The description of the incident.
        /// </summary>
        [JsonProperty("description")]
        public TextContentDto Description { get; set; }

        /// <summary>
        ///  The ID of the incident owner.
        /// The list of all available users is in the
        /// fullOrgDTO (users property)
        /// .
        /// </summary>
        [JsonProperty("owner_id")]
        public ObjectHandle OwnerId { get; set; }

        /// <summary>
        ///  The ID of phase the incident is currently in (e.g. Engage, Detect/Analyze, Respond, Post-Incident).
        /// The possible values are available in the
        /// fullOrgDTO (phases property)
        /// .
        /// </summary>
        [JsonProperty("phase_id")]
        public ObjectHandle PhaseId { get; set; }

        /// <summary>
        ///  The incident's severity.
        /// </summary>
        [JsonProperty("severity_code")]
        public ObjectHandle SeverityCode { get; set; }

        /// <summary>
        ///  The incident status.
        /// The possible values with their names are available in
        /// constDTO (incident_statuses property)
        /// .
        /// </summary>
        [JsonProperty("plan_status")]
        public string PlanStatus { get; set; }

        /// <summary>
        ///  true if this is a training incident (aka simulation).  false indicates that it is a normal incident.
        /// </summary>
        [JsonProperty("inc_training")]
        public bool IncTraining { get; set; }

    }
}
