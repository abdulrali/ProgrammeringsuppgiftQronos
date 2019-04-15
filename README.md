# ProgrammeringsuppgiftQronos

**Version 1.0.0**

A README for the programming assignment given by Qronos AB.

## Getting started
The goal of the assignment is to implement a webservice API that will search for books. The data source for this assignment consisted of a XML file that was recieved together with the instructions.

## Development remarks
Within the XmlHelper folder the XmlDocumentHandler class can be found. This class contains the method GetBooksFromDocument that loops through the books in the Xml file books.xml and adds them to a list called books.

When running the program, the HomeController is called that will load the Xml file books.xml. Thereafter the GetBooksFromDocument method is called. When you press search with a empty searchbar, all books will be fetched to the view. If you wanna search by title, you can type in some text and the view will return any title's that match your search string. The same goes for searching by id.

## Instructions
Once you run program, the catalog of books is fetched. Search for a desired book by title or id. The solution is not case sensitive. The _xmlDocument path might need to be updated to your local path for the books.xml file. 


---

## Contributors

-Abdul Ali <abdulrali95@gmail.com>
## License & copyright

@Abdul Ali, Lunds Universitet
