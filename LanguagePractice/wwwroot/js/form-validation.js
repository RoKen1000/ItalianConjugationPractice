$(document).ready(function () {
    //const conjugations = @Html.Raw(Json.Serialize(Model));

    $("#conj-form").on("submit", function (event) {
        event.preventDefault();

        $("#conj-form :input:not(:submit)").each(function () {
            if (this.value.toLowerCase() === conjugations[this.id]) {
                $("small#" + this.id).html("Correct!").css("color", "green")
            } else {
                $("small#" + this.id).html("Incorrect. Try again.").css("color", "red");
            }
        });

    })
})