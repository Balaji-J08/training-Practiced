//rest parameters
var count:any="";
function present(...num:number[])
{
    count++;
console.log("The passed numbers are as folows: "+num+ " : "+count);

    

}
present(1);
present(1,2);
present(1,2,3,4,5,6,7,8,9);
