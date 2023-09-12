console.log("Checking jsPDF outside ready function:", typeof jsPDF !== 'undefined');

function captureDivContent(selector) {
    const element = document.querySelector(selector);
    return element ? element.innerHTML : "";
}

console.log("html2canvas loaded (outside ready function):", typeof html2canvas !== 'undefined');

$(document).ready(function () {
    console.log("html2canvas loaded (inside ready function):", typeof html2canvas !== 'undefined');

    window.getPDFBase64 = async function () {
        console.log("html2canvas loaded (inside getPDFBase64):", typeof html2canvas !== 'undefined');

        try {
            if (typeof html2canvas === 'undefined') {
                throw new Error("html2canvas is not loaded.");
            }

            if (typeof jsPDF === 'undefined') {
                throw new Error("jsPDF is not loaded.");
            }

            const canvas = await html2canvas(document.getElementById('testResults'));
            console.log("Canvas Width:", canvas.width);
            console.log("Canvas Height:", canvas.height);
            const imgData = canvas.toDataURL('image/png');

            const a4WidthMm = 190;  
            const a4HeightMm = 277;  

            const aspectRatio = canvas.width / canvas.height;
            let targetWidth = a4WidthMm; 
            let targetHeight = targetWidth / aspectRatio;

            if (targetHeight > a4HeightMm) {
               
                targetHeight = a4HeightMm; 
                targetWidth = targetHeight * aspectRatio;
            }

            var pdf = new jsPDF();
            pdf.addImage(imgData, 'PNG', 10, 10, targetWidth, targetHeight);

            return pdf.output('datauristring');
        } catch (error) {
            console.error("Error generating PDF:", error);
            throw error;
        }
    };
});

  $('#emailConfirmationModal').modal('show');
