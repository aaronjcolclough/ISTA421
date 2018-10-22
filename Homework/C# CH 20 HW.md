1. **What is a delegate? Explain delegates in terms of pointers and reference types.**

A reference to a method;

2. **How do you declare a delegate? Include a discussion of types, return values, names, and parameters.**

delegate void methodName()
You use the delegate keyword. You specify the return type (void in this example), a name for the delegate (methodName), and any parameters (there are none in this case).

3. **How do you create instances of delegates and assign values to the instance? What are the values?**

 You can create an instance and make it refer to a matching method by using the += compound assignment operator within the constructor of the class.

4. **How do you invoke a method that has been added to a delegate?**

By calling the delegate???

5. **What is an event? Why do we have events?**

Events enable a class or object to notify other classes or objects when something of interest occurs. You can use to deﬁne and trap signiﬁcant actions and arrange for a delegate to be called to handle the situation.

6. **How do you declare events?**

You declare an event similarly to how you declare a ﬁeld. However, because events are intended to be used with delegates, the type of an event must be a delegate, and you must preﬁx the declaration with the event keyword.

event delegateTypeName eventName

7. **How do delegates recognize event subscriptions? How do you unsubscribe an event from a delegate?**

+= operator
-= operator

8. **How do you raise an event? How do you declare code that raises an event?**

By calling it like a method. null check???

9. **Explain with speciﬁcity what happens when an event ﬁres and that event has been attached to a delegate.**
