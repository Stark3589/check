

/* This script and many more are available free online at
The JavaScript Source :: http://javascript.internet.com
Created by: Corneliu Lucian 'Kor' Rusu :: corneliulucian[at]gmail[dot]com */

var r={
    'special':/[\W]/g,
    'quotes':/['\''&'\"']/g,
    'notnumbers':/[^\d]/g,
    'notcharacters':/[^a-zA-Z]/g
}

function valid(o,w){
    o.value = o.value.replace(r[w],'');
}