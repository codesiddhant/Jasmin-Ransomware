$(document).ready(function() {

    var state = false;

    //$("input:text:visible:first").focus();

    $('#accesspanel').on('submit', function(e) {

        e.preventDefault();

        document.getElementById("litheader").className = "poweron";
        document.getElementById("go").className = "";
        document.getElementById("go").value = "Initializing...";

        $.ajax({
               type: "POST",
               url: 'checklogin.php',
               data: $(this).serialize(),
               success: function(data)
               {
                  if (data === 'success') {
				  
                    window.location = './assets/other/loading.php';
                  }
                  else {
					  
                    document.getElementById("litheader").className = "";
                    document.getElementById("go").className = "denied";
                    document.getElementById("go").value = "Access Denied";
                      
                  }
               }
        });



        /*
        state = !state;

        if (state) {
            document.getElementById("litheader").className = "poweron";
            document.getElementById("go").className = "";
            document.getElementById("go").value = "Initializing...";
        }else{
            document.getElementById("litheader").className = "";
            document.getElementById("go").className = "denied";
            document.getElementById("go").value = "Access Denied";
        }
        */

    });

});