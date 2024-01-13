let QRCode = require('../../node_modules/qrcode-svg');

interface QrCodeOptions { 
    color: string;
    height: number;
    width: number;
}

export function init({ domId, options }: { domId: string, options: QrCodeOptions }) {
    let qrDomObject = document.querySelector(`.${domId}`);
    let qrCode = new QRCode({
        content: qrDomObject.getAttribute("href"),
        color: options.color,
        width: options.width,
        height: options.height,
        join: true,
        ecl: "L",
        padding: 0,
    });
    qrDomObject.innerHTML = qrCode.svg();
}

export function downloadSvg({ domClass, fileName }: { domClass: string, fileName: string }) {
    let qrDomObject = document.querySelector(`.${domClass}`);
    let svgData = qrDomObject.innerHTML;
    let blob = new Blob([svgData], { type: "image/svg+xml;charset=utf-8" });
    let url = URL.createObjectURL(blob);

    let downloadLink = document.createElement("a");
    downloadLink.href = url;
    downloadLink.download = fileName;
    document.body.appendChild(downloadLink);
    downloadLink.click();
    document.body.removeChild(downloadLink);
}

// so it can be called from the HTML when content re-initializes dynamically
const winAny = (window as any);
winAny.appQr2 ??= {};
winAny.appQr2.init ??= init;
winAny.appQr2.downloadSvg ??= downloadSvg;
