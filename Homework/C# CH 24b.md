1. **What are the two scenarios in which you can use PLINQ to speed up operations? Why does using PLINQ in these scenarios speed up processing?**

PLINQ is ideal for scenarios that involve data sets with large numbers of elements, or if the criteria specified for matching data involve, complex, computationally expensive operations.

2. **How doesAsParallel qualify as an extension method? First, explain what an extension method is and how you deﬁne extension methods, and them explain why AsParallel qualiﬁes as an extension method.**

Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type. Extension methods are a special kind of static method, but they are called as if they were instance methods on the extended type. The most common extension methods are the LINQ standard query operators that add query functionality to the existing System.Collections.IEnumerable and System.Collections.Generic.IEnumerable types. To use the standard query operators, first bring them into scope with a using System.Linq directive. Then any type that implements IEnumerable appears to have instance methods such as GroupBy, OrderBy, Average, and so on.

3. **How do you cancel a PLINQ query before it ﬁnishes? Be speciﬁc with respect to the variables and methods used for the cancellation operation, and how the variables and methods are used.**

You can cancel a PLINQ query by specifying a CancellationToken object from a CancellationTokenSource and use the WithCancellation extension method of the ParallelQuery. You use it once and it applies to all.

4. **Why is it important to synchronize concurrent access to a server? Give an example of a speciﬁc condition that will cause an error in your application if concurrent access is not synchronized.**

If two tasks attempt to access and modify the same data. If both tasks run at the same time, their overlapping operations might corrupt the data. This situation can lead to bugs that are difficult to correct, primarily because of their unpredictability.

5. **What does the lock statement do?**

You can use the lock keyword to guarantee exclusive access to resources. (Mutex - Mutually-exclusive)

6. **This is not in the book. Deﬁne mutex, deﬁne semaphore, and explain the diﬀerence between them.**

The mutex class is a synchronization primitive that can also be used for inter-process synchronization. A semaphore class limits the number of threads that can access a resource or pool of resources concurrently.

7. **What does it mean to say that some collection classes are not thread safe? Explain how not being thread safe may lead one of these collection classes to produce a malfunction in the program.**

Not thread safe: Code should not be accessed simultaneously by different threads.
"race conditions"

8. **Explain how thread safe collection classes are made thread safe.**

synchronization primitives

9. **Why are thread safe classes slower than non-thread safe classes? Be speciﬁc.**

Some of the concurrent collection types use lightweight synchronization mechanisms such as SpinLock, SpinWait, SemaphoreSlim, and CountdownEvent, which are new in the .NET Framework 4. These synchronization types typically use busy spinning for brief periods before they put the thread into a true Wait state. When wait times are expected to be very short, spinning is far less computationally expensive than waiting, which involves an expensive kernel transition. For collection classes that use spinning, this efficiency means that multiple threads can add and remove items at a very high rate. For more information about spinning vs. blocking, see SpinLock and SpinWait. The ConcurrentQueue and ConcurrentStack classes do not use locks at all. Instead, they rely on Interlocked operations to achieve thread-safety.
