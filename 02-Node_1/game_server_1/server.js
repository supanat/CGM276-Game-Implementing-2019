
var express = require('express');
var app = express();
var fs = require('fs');

app.get("/",function(req,res){
    res.send("Hello World");
});

app.get("/users",function(req,res){

    fs.readFile(__dirname+"/"+"user.json","utf8",function(err,data){
        console.log(data);
        res.send(data);
    });

});


var server = app.listen(8081,function(){
    var host = server.address().address;
    var port = server.address().port;

    console.log("App listening at http://%s:%s",host,port);
});