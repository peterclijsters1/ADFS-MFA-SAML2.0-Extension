﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SecondFactorAuthRequest.cs" company="Winvision bv">
//   Copyright (c) Winvision bv.  All rights reserved.
// </copyright>
// <summary>
//   Contains the data to do a second factor authentication request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace SURFnet.Authentication.Core
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// Contains the data to do a second factor authentication request.
    /// </summary>
    [Serializable]
    public class SecondFactorAuthRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecondFactorAuthRequest" /> class.
        /// </summary>
        /// <param name="originalQueryString">The original signed SAML request created by ADFS.</param>
        /// <param name="authMethod">The authentication method used by ADFS.</param>
        /// <param name="context">The encrypted context generated by ADFS.</param>
        public SecondFactorAuthRequest(string originalQueryString, string authMethod, string context)
        {
            this.OriginalRequest = originalQueryString;
            this.AuthMethod = authMethod;
            this.AdfsContext = context;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecondFactorAuthRequest" /> class.
        /// </summary>
        /// <param name="url"> The ADFS request URL including the SAML request and signing.</param>
        public SecondFactorAuthRequest(Uri url)
        {
            this.OriginalRequest = url.ToString();
        }

        /// <summary>
        /// Gets the ADFS request URL including the SAML request and signing. We need this, because we have to a post back with
        /// exact the same query string parameters to end up in the TryEndAuthentication of the plugin.
        /// </summary>
        /// <value>The original SALM request and signature.</value>
        public string OriginalRequest
        {
            get;
        }

        /// <summary>
        /// Gets the encrypted context generated by ADFS.
        /// </summary>
        /// <value>The ADFS context.</value>
        public string AdfsContext
        {
            get;
        }

        /// <summary>
        /// Gets the authentication method used by ADFS.
        /// </summary>
        /// <value>The authentication method.</value>
        public string AuthMethod
        {
            get;
        }

        /// <summary>
        /// Gets or sets the created SAML request for the second factor request.
        /// </summary>
        /// <value>The SAMl request.</value>
        public string SamlRequest
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the signing algorithm for the SAML request.
        /// </summary>=
        /// <value>The signing algorithm.</value>
        public string SigAlg => "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";

        /// <summary>
        /// Gets or sets the signature of the SAML request.
        /// </summary>
        /// <value>The signature.</value>
        public string SamlSignature
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the authentication request signature.
        /// </summary>
        /// <value>The authentication request signature.</value>
        public string AuthRequestSignature
        {
            get;
            set;
        }

        /// <summary>
        /// Serializes this instance.
        /// </summary>
        /// <returns>The JSON.</returns>
        public string Serialize()
        {
            var json = JsonConvert.SerializeObject(this);
            return Uri.EscapeDataString(json);
        }
    }
}