# Ex5-Animator-Movement

## Aim:
To develop a animator movement for a player using unity.

## Algorithm:
## Step 1: 

Import necessary models.

## Step 2: 

 Right-click -> Create -> Animator Controller.

## Step 3: 

Open Animator window, define states (Idle, Run, Jump, etc.).

## Step 4: 

Use keyframes or Unity's Animation tools to animate transitions between states.

## Step 5: 

Drag Animator Controller to the GameObject in the Inspector.

## Program:
PlayerController:
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    public float InputX;
    public float InputY;
    public float InputZ;
    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        InputZ = Input.GetAxis("");
        InputY = Input.GetAxis("Vertical");
        InputX = Input.GetAxis("Horizontal");
        animator.SetFloat("InputZ", InputY);
        animator.SetFloat("InputY", InputY);
        animator.SetFloat("InputX", InputX);
    }
}

```
## Output:

![Screenshot 2024-05-07 104855](https://github.com/chandrumathiyazhagan/Ex5-Animator-Movement/assets/119393023/077e50ef-d679-42dc-a101-02a703efa77b)

## Result:

An animator movement for a player using unity is developed successfully.
