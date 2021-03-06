﻿// Copyright 2014, Google Inc. All Rights Reserved.
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

// Author: api.anash@gmail.com (Anash P. Oommen)

using Google.Api.Ads.Common.Util;

using System;

namespace Google.Api.Ads.Common.Tests.Mocks {

  /// <summary>
  /// Mock Date time provider for testing purposes.
  /// </summary>
  public class MockDateTimeProvider : DateTimeProvider {

    /// <summary>
    /// Gets the mocked time.
    /// </summary>
    public DateTime Now {
      get {
        return new DateTime(2014, 11, 3, 12, 25, 30);
      }
    }
  }
}