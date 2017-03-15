GetComponent.<Animation>().Stop();

private var i:int=0;
private var t:int=0;
private var t1:int=0;
private var n:int=5;
var Arrow5 : GameObject;
var Arrow4 : GameObject;
var Arrow3 : GameObject;
var Arrow2 : GameObject;
var Arrow1 : GameObject;
var ArrowB : GameObject;
var speed = 0.1;
var arrowp : Transform;
var projectile : Rigidbody;
function Start () {

ArrowB.GetComponent.<Renderer>().enabled=false;

}


function Update ()
{
t=1+ Time.fixedTime;
    
           if( Input.GetButtonDown( "Fire1" ) )
      {
   if (n>0){
  if(i<1){
    i=1;
 arrowshoot1();
   t1=t;
    if (!GetComponent.<Animation>().isPlaying)
 GetComponent.<Animation>().Play("Armature_002Action");
ArrowB.GetComponent.<Renderer>().enabled=true;
  
  }
 }
   
   
   
   if (n>0){
  if(t-t1>4){
  
  if(i>0)
  {
  i=2;

 
       
        if(!GetComponent.<Animation>().isPlaying)
      GetComponent.<Animation>().Play("Armature_002Actio_001");
  i=0;    
n=n-1;

var instantiatedProjectile : Rigidbody = 
		Instantiate( projectile, arrowp.transform.position, transform.rotation );
		instantiatedProjectile.velocity = transform.TransformDirection( Vector3( 0, 0, speed ) ); 
	   // Physics.IgnoreCollision( instantiatedProjectile. collider, transform.root.collider );
t1=t;

ArrowB.GetComponent.<Renderer>().enabled=false;
}
}
}  
}    



}

          
           
    function arrowshoot1()
   {
 
 
	if (n==0)
		{
		Arrow1.GetComponent.<Renderer>().enabled=false;
		Arrow2.GetComponent.<Renderer>().enabled=false;
		Arrow3.GetComponent.<Renderer>().enabled=false;
		Arrow4.GetComponent.<Renderer>().enabled=false;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		
		}
 if (n==1)
		{
		Arrow1.GetComponent.<Renderer>().enabled=false;
		Arrow2.GetComponent.<Renderer>().enabled=false;
		Arrow3.GetComponent.<Renderer>().enabled=false;
		Arrow4.GetComponent.<Renderer>().enabled=false;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		}
 
  if (n==2)
		{
		Arrow1.GetComponent.<Renderer>().enabled=true;
		Arrow2.GetComponent.<Renderer>().enabled=false;
		Arrow3.GetComponent.<Renderer>().enabled=false;
		Arrow4.GetComponent.<Renderer>().enabled=false;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		}
   if (n==3)
		{
		Arrow1.GetComponent.<Renderer>().enabled=true;
		Arrow2.GetComponent.<Renderer>().enabled=true;
		Arrow3.GetComponent.<Renderer>().enabled=false;
		Arrow4.GetComponent.<Renderer>().enabled=false;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		}
  if (n==4)
		{
		Arrow1.GetComponent.<Renderer>().enabled=true;
		Arrow2.GetComponent.<Renderer>().enabled=true;
		Arrow3.GetComponent.<Renderer>().enabled=true;
		Arrow4.GetComponent.<Renderer>().enabled=false;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		} 
   if (n>=5)
		{
		Arrow1.GetComponent.<Renderer>().enabled=true;
		Arrow2.GetComponent.<Renderer>().enabled=true;
		Arrow3.GetComponent.<Renderer>().enabled=true;
		Arrow4.GetComponent.<Renderer>().enabled=true;
		Arrow5.GetComponent.<Renderer>().enabled=false;
		
		
		} 
		
	
	}
	

                 
                  
    
 
 
 
 
 
 
 
 
 
 
 
 
 
 
 
  function OnGUI () {
      
    GUI.contentColor = Color.red;  
    GUI.Label (Rect (10, 70, 200, 20), "Number of arrows= "+n);
     GUI.Label (Rect (10, 100, 350, 20), "Press "+"'"+"'"+"Fire"+"'"+"'"+" to fire arrows.");
    
      }
 