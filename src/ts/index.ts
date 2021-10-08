let QRCode = require('../../node_modules/qrcode-svg');


const winAny = (window as any);
winAny.appQr2 ??= {};
winAny.appQr2.init ??= init;

export function init({ domId }: { domId: string }) {
    let qrDomObject = document.querySelector(`.${domId}`);
    let qrCode = new QRCode({
        content: qrDomObject.getAttribute("qrContent"),
        container: "svg-viewbox",
        color: qrDomObject.getAttribute("qrColor"),
        join: true,
        ecl: "L",
        padding: 0
    });
    qrDomObject.innerHTML = qrCode.svg();
}
