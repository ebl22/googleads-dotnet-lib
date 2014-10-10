// Copyright 2012, Google Inc. All Rights Reserved.
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

using Google.Api.Ads.Dfp.Lib;
using Google.Api.Ads.Dfp.v201208;

using System;

namespace Google.Api.Ads.Dfp.Examples.CSharp.v201208 {
  /// <summary>
  /// This code example gets all orders. To create orders, run CreateOrders.cs.
  ///
  /// Tags: OrderService.getOrdersByStatement
  /// </summary>
  class GetAllOrders : SampleBase {
    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This example gets all orders. To create orders, run CreateOrders.cs.";
      }
    }

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      SampleBase codeExample = new GetAllOrders();
      Console.WriteLine(codeExample.Description);
      codeExample.Run(new DfpUser());
    }

    /// <summary>
    /// Run the code example.
    /// </summary>
    /// <param name="user">The DFP user object running the code example.</param>
    public override void Run(DfpUser user) {
      // Get the OrderService.
      OrderService orderService = (OrderService) user.GetService(DfpService.v201208.OrderService);

      // Sets defaults for page and Statement.
      OrderPage page = new OrderPage();
      Statement statement = new Statement();
      int offset = 0;

      try {
        do {
          // Create a Statement to get all orders.
          statement.query = string.Format("LIMIT 500 OFFSET {0}", offset);

          // Get orders by Statement.
          page = orderService.getOrdersByStatement(statement);

          if (page.results != null && page.results.Length > 0) {
            int i = page.startIndex;
            foreach (Order order in page.results) {
              Console.WriteLine("{0}) Order with ID = '{1}', name = '{2}', and advertiser " +
                  "ID = '{3}' was found.", i, order.id, order.name, order.advertiserId);
              i++;
            }
          }

          offset += 500;
        } while (page.results != null && page.results.Length == 500);

        Console.WriteLine("Number of results found: {0}", page.totalResultSetSize);
      } catch (Exception ex) {
        Console.WriteLine("Failed to get all orders. Exception says \"{0}\"",
            ex.Message);
      }
    }
  }
}