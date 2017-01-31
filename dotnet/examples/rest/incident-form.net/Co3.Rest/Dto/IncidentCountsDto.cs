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
    ///  This type represents the counts of records that were lost as part of an incident.
    /// </summary>
    public class IncidentCountsDto
    {

        /// <summary>
        ///  An list of objects that describes the "unassigned" records for the incident.
        /// </summary>
        [JsonProperty("unassigneds")]
        public List<GeoUnassignedDto> Unassigneds { get; set; }

        [Obsolete]
        [JsonIgnore]
        public List<GeoUnassignedDto> GeoUnassigneds
        {
            get { return Unassigneds; }
            set { Unassigneds = value; }
        }

        /// <summary>
        ///  The total number of records that were lost.  This is calculated by the server and is a readonly property.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        ///  A map of the record counts for the different geographic regions involved with the incident. For example, the following indicates that 100 records were lost in California (ID #6) and 200 records were lost in Delaware (ID #9): { "6": 100, "9": 200 }The list of possible geos (with their IDs) is available in the constDTO geos property.
        /// </summary>
        [JsonProperty("geo_counts")]
        public Dictionary<string, int> GeoCounts { get; set; }
    }
}
