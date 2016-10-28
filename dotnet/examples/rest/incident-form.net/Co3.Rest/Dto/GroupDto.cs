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
    public class GroupDto
    {

        /// <summary>
        ///  The ID of the group
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///  The name of the group.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///  Array of the IDs of the members of the group.
        /// </summary>
        [JsonProperty("members")]
        public List<ObjectHandle> Members { get; set; }

        /// <summary>
        ///  Flag to indicate if the group can be assigned to incidents.
        /// </summary>
        [JsonProperty("is_assignable")]
        public bool IsAssignable { get; set; }

        /// <summary>
        ///  Flag to indicate if the group can be assigned to incidents.
        /// </summary>
        [Obsolete]
        public bool Assignable
        {
            get { return IsAssignable; }
            set { IsAssignable = value; }
        }

        /// <summary>
        ///  The distinguished name of the LDAP group that this group should include users from.
        /// </summary>
        [JsonProperty("ldap_dn")]
        public string LdapDn { get; set; }

        /// <summary>
        ///  The LDAP users who are implicitly members of this group do to the LDAP link association.
        /// </summary>
        [JsonProperty("ldap_members")]
        public LdapGroupMembersDto LdapMembers { get; set; }

    }
}
