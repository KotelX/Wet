function myFunction() {;
    var input = $('#number')[0].value;
    var tr = $("#tabble_main tr");
    for (i = 1; i < tr.length; i++)
    {
        td = tr[i].getElementsByTagName("th")[0];
        if (td)
        {
            if (td.textContent.localeCompare(input) && input)
            {
                tr[i].style.display = "none";
            }
            else
            {
                tr[i].style.display = "";
            }
        }
    }
}