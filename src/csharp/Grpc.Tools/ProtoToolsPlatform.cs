#region Copyright notice and license

// Copyright 2018 gRPC authors.
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

#endregion

using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Grpc.Tools {
  /// <summary>
  /// A helper task to resolve actual OS type and bitness.
  /// </summary>
  public class ProtoToolsPlatform : Task {
    /// <summary>
    /// Return one of 'linux', 'macosx' or 'windows'.
    /// If the OS is unknown, the property is not set.
    /// </summary>
    [Output]
    public string Os { get; set; }

    /// <summary>
    /// Return one of 'x64' or 'x86'.
    /// If the CPU is unknown, the property is not set.
    /// </summary>
    [Output]
    public string Cpu { get; set; }


    public override bool Execute() {
      switch (Platform.Os) {
        case Platform.OsKind.Linux: Os = "linux"; break;
        case Platform.OsKind.MacOsX: Os = "macosx"; break;
        case Platform.OsKind.Windows: Os = "windows"; break;
        default: Os = ""; break;
      }

      switch (Platform.Cpu) {
        case Platform.CpuKind.X86: Cpu = "x86"; break;
        case Platform.CpuKind.X64: Cpu = "x64"; break;
        default: Cpu = ""; break;
      }
      return true;
    }
  };
}
