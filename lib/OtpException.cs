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
    /// Base class for the other OTP exception classes.
    /// </summary>
    /// <remarks></remarks>
    public abstract class OtpException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Object"/> class.
        /// </summary>
        /// Provides no message.
        /// <remarks></remarks>
        public OtpException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// Provides a detailed message.
        /// <remarks></remarks>
        public OtpException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtpException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="cause">The cause.</param>
        /// <remarks></remarks>
        public OtpException(string message, Exception cause) : base(message, cause)
        {
        }
    }
}
