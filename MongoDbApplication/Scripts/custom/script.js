//import { post } from "jquery";


$("#character-create").click(function () {
    var charName = $('#character-name').val();
    var charClass = $('#character-class').val();
    var charStrength = $('#character-strength').val();

    $.ajax({
        url: "Home/AddCharacter",
        //method: post,
        data:
        {
            name: charName,
            charClass: charClass,
            strength: charStrength
        }
    });
});