
function ReadFile(callback){
    callback();
    //console.log(callback)
}

var x = function(){
    console.log("Read File");
}

ReadFile(x);
