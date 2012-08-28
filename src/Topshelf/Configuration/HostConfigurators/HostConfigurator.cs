﻿// Copyright 2007-2012 Chris Patterson, Dru Sellers, Travis Smith, et. al.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Topshelf.HostConfigurators
{
    using Configurators;

    public interface HostConfigurator :
        Configurator
    {
        /// <summary>
        ///   Specifies the name of the service as it should be displayed in the service control manager
        /// </summary>
        /// <param name="name"> </param>
        void SetDisplayName(string name);

        /// <summary>
        ///   Specifies the name of the service as it is registered in the service control manager
        /// </summary>
        /// <param name="name"> </param>
        void SetServiceName(string name);

        /// <summary>
        ///   Specifies the description of the service that is displayed in the service control manager
        /// </summary>
        /// <param name="description"> </param>
        void SetDescription(string description);

        /// <summary>
        ///   Specifies the service instance name that should be used when the service is registered
        /// </summary>
        /// <param name="instanceName"> </param>
        void SetInstanceName(string instanceName);

        /// <summary>
        /// Enable pause and continue support for the service (default is disabled)
        /// </summary>
        void EnablePauseAndContinue();

        /// <summary>
        ///   Specifies the builder factory to use when the service is invoked
        /// </summary>
        /// <param name="hostBuilderFactory"> </param>
        void UseHostBuilder(HostBuilderFactory hostBuilderFactory);

        /// <summary>
        ///   Sets the service builder to use for creating the service
        /// </summary>
        /// <typeparam name="T"> </typeparam>
        /// <param name="serviceBuilderFactory"> </param>
        void UseServiceBuilder(ServiceBuilderFactory serviceBuilderFactory);

        /// <summary>
        ///   Sets the environment builder to use for creating the service (defaults to Windows)
        /// </summary>
        /// <param name="environmentBuilderFactory"> </param>
        void UseEnvironmentBuilder(EnvironmentBuilderFactory environmentBuilderFactory);

        /// <summary>
        ///   Adds a a configurator for the host builder to the configurator
        /// </summary>
        /// <param name="configurator"> </param>
        void AddConfigurator(HostBuilderConfigurator configurator);

        /// <summary>
        /// Parses the command line options and applies them to the host configurator
        /// </summary>
        void ApplyCommandLine();

        /// <summary>
        /// Parses the command line options from the specified command line and applies them to the host configurator
        /// </summary>
        /// <param name="commandLine"></param>
        void ApplyCommandLine(string commandLine);
    }
}