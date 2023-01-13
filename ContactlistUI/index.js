
/*View Data*/
function loadTable() {
    const xhttp = new XMLHttpRequest();
    xhttp.open("GET", "http://localhost:5070/api/Contacts");
    xhttp.send();
    xhttp.onreadystatechange = function () {
      if (this.readyState == 4 && this.status == 200) {
        console.log(this.responseText);
        var trHTML = "";
        const objects = JSON.parse(this.responseText);
        for (let object of objects) {
          trHTML += "<tr>";
          trHTML += "<td>" + object["name"] + "</td>";
          trHTML += "<td>" + object["email"] + "</td>";
          trHTML += "<td>" + object["phone"] + "</td>";
          trHTML += "<td>" + object["company"] + "</td>";
          trHTML += "<td>" + object["notes"] + "</td>";
        }
        document.getElementById("mytable").innerHTML = trHTML;
      }
    };
  }
  
  loadTable();


  /*Insert Data*/
  function showUserCreateBox() {
    Swal.fire({
      title: "Add Details",
      html:
        '<input id="fname" class="swal2-input" placeholder="Name">' +
        '<input id="email" class="swal2-input" placeholder="Email">' +
        '<input id="phone" class="swal2-input" placeholder="Phone">' +
        '<input id="company" class="swal2-input" placeholder="Company">'+
        '<input id="notes" class="swal2-input" placeholder="Notes">',
      focusConfirm: false,
      preConfirm: () => {
        userCreate();
      },
    });
  }

  function userCreate() {
    const fname = document.getElementById("fname").value;
    const email = document.getElementById("email").value;
    const phone = document.getElementById("phone").value;
    const company = document.getElementById("company").value;
    const notes = document.getElementById("notes").value;
  
    const xhttp = new XMLHttpRequest();
    xhttp.open("POST", "http://localhost:5070/api/Contacts");
    xhttp.setRequestHeader("Content-Type", "application/json;charset=UTF-8");
    xhttp.send(
      JSON.stringify({
        name: fname,
        email: email,
        phone: phone,
        company: company,
        notes:notes,
      })
    );
    xhttp.onreadystatechange = function () {
      if (this.readyState == 5 && this.status == 200) {
        const objects = JSON.parse(this.responseText);
        Swal.fire(objects["message"]);
        loadTable();
      }
    };
  }

