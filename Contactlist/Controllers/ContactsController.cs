using System;
using Microsoft.AspNetCore.Mvc;
using ContactList.Services;
using ContactList.Models;

namespace ContactList.Controllers;
[Controller]
[Route("api/[controller]")]
public class ContactsController: Controller{
 
 private readonly MongoDBService _mongoDBService;

 public ContactsController(MongoDBService mongoDBService){
    _mongoDBService = mongoDBService;
 }
 
 [HttpGet]
 public async Task<List<Contacts>> Get(){
    return await _mongoDBService.GetAsync();
 }

 [HttpPost]
 public async Task<IActionResult> Post([FromBody] Contacts contacts){
    await _mongoDBService.CreateAsync(contacts);
    return CreatedAtAction(nameof(Get), new {id=contacts.Id}, contacts);
 }

 [HttpPut("{id}")]
 public async Task<IActionResult> AddToContactsList(string id,[FromBody] string contactId){
    await _mongoDBService.AddToContactsListAsync(id, contactId);
    return NoContent();
 }

 [HttpDelete("{id}")]
 public async Task<IActionResult> Delete(string id){
    await _mongoDBService.DeleteAsync(id);
    return NoContent();
 }


}