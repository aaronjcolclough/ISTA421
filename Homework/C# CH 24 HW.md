1. **What is an asynchronous method? When the book talks about a contract, what is the contract and who is it with?**

An asynchronous method is one that does not block the current thread on which it starts to run.

2. **What can be the problem with decomposing a series of discrete method calls into a set of tasks, such as we saw in chapter 23?**

It does not wait for it to complete, so events can occur out of sequence.

3. **What can be the problem with decomposing a series of discrete method calls into a set of continuations? When does the last continuation “complete” as compared to the previous continuations? What problem might this cause?**

If there is a problem, it will block everything.

4. **What might be the problem with implementing the previous solution as a continuation passing a delegate? What would be your interpretation with this error message: “The application called an interface that was marshaled for a diﬀerent thread.”?**

If there is a problem, it will block everything. System.Exception

5. **The book suggests a solution using a continuation delegate calling another continuation delegate via an anonymous function. What does the book identify as a problem with this suggested solution?**

Difficult to maintain.

6. **What does the async modiﬁer do? What does the await operator do?**

The async modiﬁer indicates that a method contains functionality that can be run asynchronously. All it does is specify that the code in the method can be divided into one or more continuations.
The await operator speciﬁes the points at which this asynchronous functionality should be performed. It speciﬁes a point at which the C# compiler can split the code into a continuation.

7. **What is an awaitable object? Be speciﬁc.**

An awaitable object is a type that provides the GetAwaiter method, which returns an object that in turn provides methods for running code and waiting for it to complete. The C# compiler converts your code into statements that use these methods to create an appropriate continuation.

Expected to run in background.


8. **In a method deﬁnition, how do you create and run a Task and return a reference to the Task? What is the type of such a method? What does the method return?**

private Task doFirstLongRunningOperation()
{    
  Task t = Task.Run(() => { *code* });    
  return t;
}

The return is a reference to a task.

9. **How do you deﬁne method calls in the implementation of an async method? Speciﬁcally, you must deﬁne a task, you must run the task, you must implement the task, and you must await the task. What is the syntax for doing this?**

private async Task doFirstLongRunningOperation()
{
  Task first = Task.Run(() => {*code for first operation*});
  Task second = Task.Run(() => {*code for second operation*});
  await first;
  await second;
}

10. **What is the diﬀerence between decomposing a series of method calls that do not return values, and a series of method calls that return values? What is the Result property of a method that returns a value? How do you use the await operator in this circumstance?**

To do this you use the generic Task class, where the specialized type  TResult specifies the type of the result. You create and start a Task object in a similar way as for an ordinary Task. The primary difference is that the code you execute should return a value. The await operator extracts the value from the Task and assigns it to the return variable.

11. **What is the diﬀerence between the await operator and the Wait method?**

The wait method always blocks the current thread and does not allow it to be reused until the task completes.
