#pragma strict

function Start () {
	InvokeRepeating("Scale", 0, 1);
}

function Scale() {
	var randNum : int = Random.Range(1, 5);
	transform.localScale = Vector3(1, randNum, 1);
}