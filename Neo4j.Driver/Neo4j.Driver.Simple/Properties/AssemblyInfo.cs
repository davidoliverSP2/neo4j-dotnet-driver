﻿// Copyright (c) 2002-2019 "Neo4j,"
// Neo4j Sweden AB [http://neo4j.com]
// 
// This file is part of Neo4j.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Resources;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Neo4j.Driver.Simple")]
[assembly:
    AssemblyDescription(
        "The official .NET driver extension that provides blocking session API that is built on top of the default asynchronous session API.")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Neo4j.Driver")]
[assembly: AssemblyCopyright("Copyright ©  2002-2019")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en")]

#if STRONGNAMED
[assembly: AssemblySignatureKey(
    "002400000c800000140100000602000000240000525341310008000001000100d988a5d518f3e57d84d18057687648d5a4317ddd9cec3bdcb91d78565957c86e47804d3bb1fb9dd5318ccff5c25201ac130e84407f56d0f699f239bb4254a1ab40bb7baf2453c0f0316ed4f330e24a2983aced0f64ec7f281ef26a4df06039cf55b341c29e27361d83a3d4d5b1279a5b1ad4061ae7585623c08fc36a3f12bf4fa9447d4931a82d12ea913c99f614c17d86f3dfa1f5f10e36fb14f06a769c29e0bb18e3b3813275af3328cbf5bfc4ebd55589b5f25afde1dac8eccf7c1996a032ba6dc09d96a9377e88b5bc85aa2596fcdb45d3bb56ec225a832b1b8ae8f0e588a2bc04a98a208752cccb6772711bf34c8cf4a4b779a44ebb39b0c6a0a184cae7", 
    "136d782a15af084ba55c3a4d38bbefa7afe42502043cea43b89736703d08208503c89121f693935aad8a36bb2e608e58b6f6ee7f858bc0558385f20fc691ecf2640c64c304eddf1a74a7a37c45a9ed2aa5ae7a6fad3a50961d167fd7004c2547a2a1690258fd110ed851107bfeed2084d05b6f29b2bbbaeece1e816dce850911ee2c4f5e8b1ecd9b130a6433dc750eeb34b80173718384ca2b9a00675de59661d165171c5907ffbd876525381025376b72008935dede0f7a6c7bc8258cb9aa99a0160d0eff372d4ff59cb24d3095d197bf85653835b44500786dc208e685a54f86ee86b415c978c65d392a3a29dfe67aa2e25801f04d827917b55590216e8d18")]

[assembly: InternalsVisibleTo("Neo4j.Driver.Tests, publicKey=0024000004800000140100000602000000240000525341310008000001000100a1db9b807e2c456c444cd28c1e79b3ff4ad30d7768b05b67711a230b771b3717520403fd594f43ad14636f89fa2315c097a3a0c72ba8b466b66b43889389be18444da8f32f8f758ae1e12c68540b19bb987f7f7b0c6bea27b3dffc23a56eac4dc3e28cc780abbdb80bc19e53b20eb27eeefe00f9f47adfb1faecfefc251959dbb8b4ed190e32cd52986198d8ec934f9fbfc2502bee6718705ee660b72c9ba3ee29d7eea2d26f2c1f586a298597315c9d8fc497299b6693f2a07eb46fcb5534d0c157545384431eeac42a83ebf68dcac4b0a3a1b080b40b94cc25ed722c66edbbd372494063e59f6191d974e8c743dc7da174bffa0deedf9522ecb8d1694173ac")]
[assembly: InternalsVisibleTo("Neo4j.Driver.Tests.Integration, publicKey=0024000004800000140100000602000000240000525341310008000001000100a1db9b807e2c456c444cd28c1e79b3ff4ad30d7768b05b67711a230b771b3717520403fd594f43ad14636f89fa2315c097a3a0c72ba8b466b66b43889389be18444da8f32f8f758ae1e12c68540b19bb987f7f7b0c6bea27b3dffc23a56eac4dc3e28cc780abbdb80bc19e53b20eb27eeefe00f9f47adfb1faecfefc251959dbb8b4ed190e32cd52986198d8ec934f9fbfc2502bee6718705ee660b72c9ba3ee29d7eea2d26f2c1f586a298597315c9d8fc497299b6693f2a07eb46fcb5534d0c157545384431eeac42a83ebf68dcac4b0a3a1b080b40b94cc25ed722c66edbbd372494063e59f6191d974e8c743dc7da174bffa0deedf9522ecb8d1694173ac")]
// Required for Moq to function in Unit Tests
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7")]
#else
[assembly: InternalsVisibleTo("Neo4j.Driver.Tests")]
[assembly: InternalsVisibleTo("Neo4j.Driver.Tests.Integration")]
// Required for Moq to function in Unit Tests
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif