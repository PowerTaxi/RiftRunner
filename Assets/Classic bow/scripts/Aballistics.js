var speed1:int=50;
 
   var rig : Rigidbody;
rig = GetComponent.<Rigidbody>();

 var trans : Transform;
trans = transform;

private var vel : Vector3;
private var pos : Vector3;

private var plu : Vector3;
plu = Vector3(0,0,2); 

rig.angularDrag = 0.5;

function Start()
{
        rig.AddForce (-trans.forward*speed1 , ForceMode.VelocityChange);
}

function FixedUpdate ()
{
        pos = trans.position+trans.TransformDirection(plu);
        vel = trans.InverseTransformDirection (rig.velocity);
        vel.z = 0;
        vel = -vel/1000;
        vel = trans.TransformDirection (vel);
        rig.AddForceAtPosition(vel,pos,ForceMode.VelocityChange);
}