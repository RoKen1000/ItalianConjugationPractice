
$(".submit-buttons").on("click", function () {
    setTimeout(() => {

        let correctAnswers = 0;

        $("#conj-form").find("small").each(function () {
            if ($(this).attr("class") === "correct-animation") {
                correctAnswers++;
            }
        });

        if (correctAnswers === 6) {
            $("#next-word").removeAttr("disabled");
        }
    }, 50)
})