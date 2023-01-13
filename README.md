# ASP.NET Core WebApi Contact Management


#             API     CRUD      Testing     
Hope this helps.

## Versions

```http://localhost:5070/swagger ```


## GET all contacts

``` http://localhost:5070/api/Contacts ```


## POST a contact

``` http://localhost:5070/api/Contacts ```

```
{
  "id": "dpqqnf139134",
  "name": "string",
  "email": "string@gmail.com",
  "phone": "0614113855",
  "company": "string",
  "notes": "string"
}
```

## PUT a contact

``` http://localhost:5070/api/Contacts/{id} ```

``` 
{
  "id": "dpqqnf139134",
  "name": "string",
  "email": "string@gmail.com",
  "phone": "0614113855",
  "company": "string",
  "notes": "string"
}
```


## DELETE Contact

``` http://localhost:5070/api/Contacts/{id}```


# End Of API CRUD

# Two folders one for back-end(CONTACTLIST) and Front-end()
# Front End

They is two ways to access front-end 
1. Run the code locally through the folder
2.Access it online using this URL https://mdawedavid.bsite.net/

using hosted front-end The user/developer must run the back-end(API) locally so that the data can be shown.
The user must access the online front-end using the same machine where the back-end is running(Locally).

# Back-end
 They is a back-end folder containing all the code.

# Database connection 
MongoDB Atlas 
Connection Details below:

"ConnectionURI":  "mongodb+srv://mongo:david1925@cluster0.bzzdwbb.mongodb.net/?retryWrites=true&w=majority",
    "DatabaseName":  "ManageContact",
    "CollectionName":  "Contacts"

