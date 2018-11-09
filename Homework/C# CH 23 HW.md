1. **List two reasons for multitasking, and explain the rationale for them.**

To improve responsiveness - it does not make sense to have a program burn CPU cycles waiting for the operation to complete when the program could be doing something more useful instead (such as responding to user input).

To improve scalability - If an operation is CPU bound, you can improve scalability by making efﬁcient use of the processing resources available and using these resources to reduce the time required to execute the operation. Tasks can be performed in parallel and be arranged to be run concurrently.

2. **Explain Moore’s law. What does Moore’s law have to do with multitasking?**

 The number of transistors that can be placed inexpensively on an integrated circuit will increase exponentially, doubling approximately every two years. This meant we could expect to see chip manufacturers produce faster and more powerful microprocessors at an almost unrelenting pace, enabling software developers to write ever more complicated software that would run more quickly.

3. **In UWP, what namespace is used as the container for the multitasking methods?**

System.Threading.Tasks

4. **What is the diﬀerence between tasks and threads? Explain.**

A task is something you want to be done. A thread is the way the get it done.

5. **What is the ThreadPool?**

A pool of threads that can be used to execute tasks, post work items, process asynchronous I/O, wait on behalf of other threads, and process timers.
The ThreadPool class implements a number of optimizations and uses a work-stealing algorithm to ensure that threads are scheduled efﬁciently.


6. **What parameters does the Task() constructor take?**

Action delegates

7. **How do you start a thread?**

thread.Start()

8. **What is the diﬀerence between the Start() and Run() methods?**

The Start method is overloaded, and you can optionally specify a TaskCreationOptions object to provide hints about how to schedule and run the task.
The Run method takes an Action delegate specifying the operation to perform (like the Task constructor) but starts the task running immediately. It returns a reference to the Task object.

9. **What is the diﬀerence between creating independent tasks with Tasks and parallelization with Parallel? Explain.**

Parallelization reduces the time taken for the application to run by spreading the computations across multiple processor cores.


10. **Explain how manual cancellation works using a cancellation token.**

An application obtains a CancellationToken by creating a System.Threading. CancellationTokenSource object and querying the Token property of this object. The application can then pass this
 CancellationToken object as a parameter to any methods started by tasks that the  application creates and runs. If the application needs to cancel the tasks, it calls the Cancel method of the  CancellationTokenSource object. This method sets the IsCancellationRequested property of the CancellationToken passed to all the tasks.
