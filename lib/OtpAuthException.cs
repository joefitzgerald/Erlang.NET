
/*
 * %CopyrightBegin%
 * 
 * Copyright Takayuki Usui 2009. All Rights Reserved.
 * Copyright Ericsson AB 2000-2009. All Rights Reserved.
 * 
 * The contents of this file are subject to the Erlang Public License,
 * Version 1.1, (the "License"); you may not use this file except in
 * compliance with the License. You should have received a copy of the
 * Erlang Public License along with this software. If not, it can be
 * retrieved online at http://www.erlang.org/.
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See
 * the License for the specific language governing rights and limitations
 * under the License.
 * 
 * %CopyrightEnd%
 */
using System;

namespace Erlang.NET
{
    /// <summary>
    /// Exception raised when a node attempts to establish a communication channel
    /// when it is not authorized to do so, or when a node sends a message containing
    /// an invalid cookie on an established channel.
    /// </summary>
    /// <remarks></remarks>
    public class OtpAuthException : OtpException
    {
        /// <summary>
        /// The serial version unique identifier.
        /// </summary>
        internal static readonly long serialVersionUID = 1L;

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpAuthException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <remarks></remarks>
        public OtpAuthException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpAuthException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cause">The cause.</param>
        /// <remarks></remarks>
        public OtpAuthException(string message, Exception cause) : base(message, cause)
        {
        }
    }
}
