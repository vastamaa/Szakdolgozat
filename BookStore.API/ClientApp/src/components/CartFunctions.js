export function MinusAmount (){
    var b=document.getElementById('isbn').innerHTML
    var a=document.getElementById('amount').value
    if(a==1){
        localStorage.removeItem(document.getElementById('isbn').innerHTML)
        console.log(b)
        window.location.reload(false);
    }
    else
    {
        document.getElementById('amount').value=a-1;
    }
}
export function PlusAmount(){
    var a=document.getElementById('amount').value
    a++;
    document.getElementById('amount').value=a
}
