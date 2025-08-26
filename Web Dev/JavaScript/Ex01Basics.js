//JS is a client side scripting language used for creating dynamic content in HTML. JS is the default scripting language for all browsers.
//Microsoft based browsers support additional scripting languages called VBScript.
//JS is maintained by ECMA(European Computers manufacturers Association), it releases newer versions every year.
//There are 3 UI based functions in JS that can be used for UI interactions, alert , prompt and confirm
//Alert is like a message box that draws the attention of the user and waits till the user performs or closes that dialogue.
//Prompt is more like a question and answer, where the input is a written value of a function.
//Confirm is more like a confirmation window where a user can accept or reject the information in the form of OK and cancel.
alert("Welcome")
let result=prompt("Enter your name: ")
let answer=confirm(`Is the name entered ${result} correct`)
if(answer){
    alert("Correct")
}
else{
    alert("Not Correct")
}

