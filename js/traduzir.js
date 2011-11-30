///<script type="text/javascript">

// Initialize version 1.0 of Google AJAX API
google.load("language", "1");

function traduzir(lang) {
    var source = document.getElementById("nao_traduzido").innerHTML;
    //var len = content.length;
    var len = source.length;
    
    // Google Language API accepts 500 characters per request 
    var words = 500;
    
    // This is for English pages, you can change the
    // sourcelang variable for other languages
    var sourcelang = "pt";
    document.getElementById("traducao").innerHTML = "";
    
    for(i=0; i<=(len/words); i++) {
        google.language.translate (source.substr(i*words, words),
                    'en', lang, function (result)
        {
            if (!result.error) {
            document.getElementById("traducao").innerHTML
                = document.getElementById("traducao").innerHTML
                + result.translation;
            }
        } );
    }

    // Hide the text written in the original language
    document.getElementById("nao_traduzido").style.display = 'none';
    return false;
}

// Switch to the original language

function original() {
    document.getElementById("traducao").style.display='none';
    document.getElementById("nao_traduzido").style.display = 'block';
    return false;
}

///</script>