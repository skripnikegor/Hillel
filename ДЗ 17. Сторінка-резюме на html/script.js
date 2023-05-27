function validateForm() {
    let x = document.forms["form"]["fname"].value;
    if (x == "") {
      alert("Name must be filled out");
      return false;
    }
  }