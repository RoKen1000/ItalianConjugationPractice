$(document).ready(function () {

    const toBeConjugations = {
        firstPersonSingularDemo: "am", secondPersonSingularDemo: "are", thirdPersonSingularDemo: "is",
        firstPersonPluralDemo: "are", secondPersonPluralDemo: "are", thirdPersonPluralDemo: "are"
    }

    $("#conj-form-demo").on("submit", function (event) {
        event.preventDefault();

        $("#conj-form-demo :input:not(:submit)").each(function () {
            if (this.value.toLowerCase() === toBeConjugations[this.id]) {
                $("small#" + this.id).html("Correct!").css("color", "green")
            } else {
                $("small#" + this.id).html("Incorrect. Try again.").css("color", "red");
            }
        });

    })
})