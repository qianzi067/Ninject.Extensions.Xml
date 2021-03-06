//-------------------------------------------------------------------------------
// <copyright file="TransientScopeHandler.cs" company="Ninject Project Contributors">
//   Copyright (c) 2009-2011 Ninject Project Contributors
//   Authors: Remo Gloor (remo.gloor@gmail.com)
//           
//   Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
//   you may not use this file except in compliance with one of the Licenses.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//   or
//       http://www.microsoft.com/opensource/licenses.mspx
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.Extensions.Xml.Scopes
{
    using Ninject.Components;
    using Ninject.Syntax;

    /// <summary>
    /// The processor for the transient scope
    /// </summary>
    public class TransientScopeHandler : NinjectComponent, IScopeHandler
    {
        /// <summary>
        /// The identification name of the transient scope.
        /// </summary>
        public const string Name = "transient";

        /// <summary>
        /// Gets the name of the scope processed by this instance.
        /// </summary>
        /// <value>The name of the scope processed by this instance.</value>
        public string ScopeName
        {
            get
            {
                return Name;
            }
        }

        /// <summary>
        /// Sets the scope using the given syntax.
        /// </summary>
        /// <param name="syntax">The syntax that is used to set the scope.</param>
        public void SetScope(IBindingInSyntax<object> syntax)
        {
            syntax.InTransientScope();
        }
    }
}