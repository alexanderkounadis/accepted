# accepted

This is a simple web api project written in .net core 3.0
As a store system I have used LiteDb, an Embedded NoSQL database for .NET (https://www.litedb.org/)
This api is about storing and getting book entities in a json format
There is a get method (https://localhost:44356/api/book/{{id}}) which retrieves a book by its id
There is a post method (https://localhost:44356/api/book/) which stores a book entity by providing 
a json entity in the body e.g:

{
		    "Id":5,
		    "ISBN" : "9780451494344",
        "Title": "The Girl Who Lived Twice : A Lisbeth Salander Novel, Continuing Stieg Larsson's Millennium Series",
        "Price": 24.32,
        "Author":" David Lagercrantz",
        "Summary":"The sixth Lisbeth Salander story--the crime-fiction phenomenon that has sold more than 90 million copies worldwide."
}

You could debug the api locally and send a post request using postman or fiddler (id is a unique identifier for the book entity in the no sql store - so use values greater than 5 for it).

After posting a book, you could get it in json format sending a get request by its id.

