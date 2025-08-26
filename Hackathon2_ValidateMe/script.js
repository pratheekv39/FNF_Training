function validateForm() {
  let message = "";
  const username = document.getElementById("username").value;
  const pin = document.getElementById("pin").value;
  const states = document.getElementById("states").value;
  const validatePin = document.getElementById("validatePin").checked;
  const testMe = document.getElementById("testMe").checked;

  // Username validation
  if (username.length < 6 || username.length > 8) {
    message += "Username not validated<br>";
  }

  // Pin validation
  if (validatePin) {
    const alphanumericRegex = /^[a-zA-Z0-9]+$/;
    if (!pin || !alphanumericRegex.test(pin)) {
      message += "Pin not validated<br>";
    }
  }

  // States validation
  if (!states) {
    message += "States not validated<br>";
  }

  // Test me checkbox
  message += `Test me is ${testMe ? "checked" : "unchecked"}<br>`;

  // Radio button validation
  const dairyOptions = document.getElementsByName("dairy");
  let selected = false;
  for (let option of dairyOptions) {
    if (option.checked) {
      selected = true;
      break;
    }
  }
  if (!selected) {
    message += "Dairy option not selected<br>";
  }

  document.getElementById("message").innerHTML = message || "Form validated successfully!";
}