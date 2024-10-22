function generateRandomNumber() {
    const randomNumber = Math.floor(Math.random() * 100) + 1;
    const centerBox = document.getElementById("center-box");
    centerBox.textContent = randomNumber;

    
    const list = document.querySelectorAll("#input1,#input2,#input3,#input4");
    list.forEach(input => input.value = "");
    list.forEach(list => {
        list.style.backgroundColor = "white";
    });
}

function validereInput() {
    const randomNumber = parseInt(document.getElementById("center-box").textContent);

    const inputs = [
        { element: document.getElementById("input1"), expectedChange: 10 },
        { element: document.getElementById("input2"), expectedChange: -1 },
        { element: document.getElementById("input3"), expectedChange: 1 },
        { element: document.getElementById("input4"), expectedChange: -10 }
    ];

    inputs.forEach(input => {
        const userValue = parseInt(input.element.value);

        const expectedValue = randomNumber + input.expectedChange;

        if (userValue === expectedValue) {
            input.element.style.backgroundColor = "lightgreen";
        } else {
            input.element.style.backgroundColor = "lightcoral";
        }
    });
}