function checkForm()
  {
     var isEmpty = 0;

     if(document.getElementById('fname').value == "")
     {
        isEmpty = 1;
        
     }
     if(document.getElementById('lname').value == "")
     {
        isEmpty = 1;
     }
	 
     if(document.getElementById('ymail').value == "")
     {
        isEmpty = 1;
     }
	 
     if(document.getElementById('birthday').value == "")
     {
        isEmpty = 1;
     }
	 
     
    if(isEmpty == 1)
    {
	alert("Plaese fill required fields!");
  }
  }
  
