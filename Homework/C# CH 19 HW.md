1. **What is an enumerable collection?**

The quick answer is that it is a collection that implements the System.Collections.IEnumerable interface.


2. **What properties and methods does the IEnumerable interface contain?**

IEnumerator GetEnumerator();

3. **What properties and methods does the IEnumerator interface contain?**

object Current { get; }
bool MoveNext();
void Reset();

4. **What values does the MoveNext() method return? What does it do?**

True/False

5. **What values does the Reset() method return? What does it do?**

void

6. **Are IEnumerable and IEnumerator type safe? Why or why not? If not, how do you implement type safety?**

They are not, because the different types have different properties and methods.

7. **Why don’t recursive methods retain state when used with data structures like binary trees?**

To cut down memory usage.

8. **How do you deﬁne an enumerator?**

public IEnumerator GetEnumerator()

9. **What is an iterator?**

An iterator is a block of code that yields an ordered sequence of values.

10. **What does yield do?**

YIELD indicates the value that should be returned by each iteration. It is calling a temporary halt to the method, passing back
