1. **What is the diﬀerence in the purposes of SQL and LINQ? In other words, why do we need two diﬀerent query languages? Does LINQ replace SQL? Does SQL make LINQ unnecesary?**
They operate in two different areas. SQL operates in the database. linq manipulates the data in memory. Both are needed.

2. **What is the one essential requirement for the datastructures used with LNQ? Why is this requirement important?**
Linq requires data to be stored in the IEnumerable interface which allows you to iterate through data structures one by one.

3. **Were does the LINQ Select() method live?**
In the Enumerble class within the System.Linq namespace.


4. **(Select) Explain, token by token, each token in this line of code:
IEnumerable<string> customerFirstNames = customers.Select(cust => cust.FirstName);**
type specialized in string / name / assignment operator / object / access operator / method / parameter (iteration variable / goes to / object / access operator / property)

5. **(Filter) Explain, token by token, each token in this line of code:
IEnumerable<string> usCompanies = addresses.Where(addr => String.Equals(addr.Country, "United States")).Select(usComp => usComp.CompanyName);**
type specialized in string / name / assignment operator / object / access operator / method / parameter (iteration variable / goes to / class / access operator / method / parameter (object / access operator / property / string /) access operator / method / parameter (iteration variable / goes to / object / access operator / property))

6. **(OrderBy) Explain, token by token, each token in this line of code:
IEnumerable<string> companyNames = addresses.OrderBy(addr => addr.CompanyName).Select(comp => comp.CompanyName);**
type specialized in string / name / assignment operator / object / access operator / method / parameter (iteration variable / goes to / object / access operator / property) / access operator /method / parameter (iteration variable / goes to / object / property)

7. **(Group) Explain, token by token, each token in this line of code:
var companiesGroupedByCountry = addresses.GroupBy(addrs => addrs.Country);**
type / name / assignment operator / object /access operator / method / parameter (iteration variable / goes to / object / access operator / property)

8. **(Distinct) Explain, token by token, each token in this line of code:
int numberOfCountries = addresses.Select(addr => addr.Country).Distinct().Count();**
type / name / assignment operator / object / access operator / method / parameter (iteration variable / goes to / object / access operator / property) / access operator / method / access operator / method

9. **(Join) Explain, token by token, each token in this line of code:
var companiesAndCustomers = customers.Select(c => new { c.FirstName, c.LastName, c.CompanyName }).Join(addresses, custs => custs.CompanyName, addrs => addrs.CompanyName, (custs, addrs) => new {custs.FirstName, custs.LastName, addrs.Country });**
type / name / assignment operator / object / access operator / method / parameter (iteration variable / goes to / object initialization syntax) / access operator / method /

10. **Explain the diﬀerence between a deferred collection and a static, cached collection.**
deferred only happens when the name is called. static, cached happens all at once.
