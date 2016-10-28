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
    ///  Information that is required for incidents related to HIPAA.
    /// </summary>
    public class HipaaRiskDto
    {

        /// <summary>
        ///  Given the nature and extent of the PHI involved, is it likely that the information could be used by an unauthorized recipient in a manner adverse to the individual or otherwise used to further the unauthorized recipient's own interests?
        /// Specify null to indicate that you do not know.
        /// </summary>
        [JsonProperty("hipaa_adverse")]
        public bool HipaaAdverse { get; set; }

        /// <summary>
        ///  Is it likely that the unauthorized recipient has misused or will misuse the information?
        /// Specify null to indicate that you do not know.
        /// </summary>
        [JsonProperty("hipaa_misused")]
        public bool HipaaMisused { get; set; }

        /// <summary>
        ///  Was the information actually acquired or viewed?
        /// Specify null to indicate that you do not know.
        /// </summary>
        [JsonProperty("hipaa_acquired")]
        public bool HipaaAcquired { get; set; }

        /// <summary>
        ///  Is it likely that additional or further misuse of the data will occur?
        /// Specify null to indicate that you do not know.
        /// </summary>
        [JsonProperty("hipaa_additional_misuse")]
        public bool HipaaAdditionalMisuse { get; set; }

        /// <summary>
        ///  Based on your overall assessment of the incident, is it likely that a breach has occurred? Note: A true value will result in notification tasks being generated. You may also provide true if your organization chooses to forego the assessment and notify regarding all incidents.
        /// Specify null to indicate that you do not know.
        /// </summary>
        [JsonProperty("hipaa_breach")]
        public bool HipaaBreach { get; set; }

        /// <summary>
        ///  Any additional notes relating to the hipaa_adverse property.
        /// </summary>
        [JsonProperty("hipaa_adverse_comment")]
        public string HipaaAdverseComment { get; set; }

        /// <summary>
        ///  Any additional notes relating to the hipaa_misused property.
        /// </summary>
        [JsonProperty("hipaa_misused_comment")]
        public string HipaaMisusedComment { get; set; }

        /// <summary>
        ///  Any additional notes relating to the hipaa_acquired property.
        /// </summary>
        [JsonProperty("hipaa_acquired_comment")]
        public string HipaaAcquiredComment { get; set; }

        /// <summary>
        ///  Any additional notes relating to the hipaa_additional_misuse property.
        /// </summary>
        [JsonProperty("hipaa_additional_misuse_comment")]
        public string HipaaAdditionalMisuseComment { get; set; }

        /// <summary>
        ///  Any additional notes relating to the hipaa_breach property.
        /// </summary>
        [JsonProperty("hipaa_breach_comment")]
        public string HipaaBreachComment { get; set; }

    }
}
