using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousProgramming
{
    public class TheoryAsynchronous
    {
        //Synchronous Program Execution

        /*
         * Program is executed line by line, one at a time.
         * When a function is called, program execution has to wait until the function returns.
         * 
         * 1: ...
         * 2: TimeConsumingProcess();
         * 3: ...
         * 4: ...
         */

        //Asynchronous Program Execution

        /*
         * When a function is called, program execution continues to the next line,
         * without waiting for the function to complete.
         * 
         * 1: ...
         * 2: TimeConsumingProcess(callback);
         * 3: ...
         * 4: ...
         * 
         * callback()
         * {
         *    ...
         *  }
         */

        //So what's the difference?

        /* Asynchronous programming improves responsiveness. */

        //Real-world Examples

        /*
         * Windows Media Player
         * Web Browser
         */

        //When to use asynchronous?

        /*
         * Accessing the Web
         * Working with files and databases
         * Working with images
         */

        //How?

        /*Traditional approaches:
         * - Multi-threading
         * - Callbacks
         */

        /*New approache since NET 4.5
         * - Async / Await
         */
    }
}
