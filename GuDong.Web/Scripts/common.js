/**
 * 
 * @authors Your Name (you@example.org)
 * @date    2015-05-07 14:27:16
 * @version $Id$
  "/Home/ProductList?id=0&type=search&SearchContent=" + $('#searchtxt').val();
 */

function GotoHref(url) {
    top.location.href = url;
}

function SearchClick(url) {
    var txtsearch = $('#txtsearch').val();
    if (txtsearch)
        window.location.href = url + "?id=1&search=" + txtsearch;
    else
        window.location.href = url + "?id=1";
}

function onSearchClear() {

    $('#txtsearch').val("");
}
 