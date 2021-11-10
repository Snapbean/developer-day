(function () {
    window.helloEmployee = {
        displayMessage: function (elementId, employee) {
            document.getElementById(elementId).textContent = `Hello ${employee.firstName} ${employee.lastName}`;
        }
    }
})();