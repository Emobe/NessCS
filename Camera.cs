﻿using System;
using OpenTK;
using OpenTK.Input;
namespace NessCS
{
    public class Camera
    {
        public Vector3 Position = Vector3.Zero;
        public Vector3 Orientation = new Vector3((float)Math.PI, 0f, 0f);
        public float MoveSpeed = 0.2f;
        public float MouseSensitivity = 0.01f;

        public Matrix4 GetViewMatrix()
        {
            Vector3 lookAt = new Vector3
            {
                X = (float)(Math.Sin((float)Orientation.X) * Math.Cos((float)Orientation.Y)),
                Y = (float)Math.Sin((float)Orientation.Y),
                Z = (float)(Math.Cos((float)Orientation.X) * Math.Cos((float)Orientation.Y))
            };

            return Matrix4.LookAt(Position, Position + lookAt, Vector3.UnitY);
        }

        public void Move(float x, float y, float z)
        {
            Vector3 offset = new Vector3();

            Vector3 forward = new Vector3((float)Math.Sin((float)Orientation.X), 0, (float)Math.Cos((float)Orientation.X));
            Vector3 right = new Vector3(-forward.Z, 0, forward.X);

            offset += x * right;
            offset += y * forward;
            offset.Y += z;

            offset.NormalizeFast();
            offset = Vector3.Multiply(offset, MoveSpeed);

            Position += offset;
        }

        public void AddRotation(float x, float y)
        {
            x = x * MouseSensitivity;
            y = y * MouseSensitivity;

            Orientation.X = (Orientation.X + x) % ((float)Math.PI * 2.0f);
            Orientation.Y = Math.Max(Math.Min(Orientation.Y + y, (float)Math.PI / 2.0f - 0.1f), (float)-Math.PI / 2.0f + 0.1f);
        }

        public void Update(double time)
        {
            if (InputManager.KeyDown(Key.W))
            {
                this.Move(0f, 0.1f, 0f);
            }
            if (InputManager.KeyDown(Key.A))
            {
                this.Move(-0.1f, 0f, 0f);
            }
            if (InputManager.KeyDown(Key.S))
            {
                this.Move(0f, -0.1f, 0f);
            }
            if (InputManager.KeyDown(Key.D))
            {
                this.Move(0.1f, 0f, 0f);
            }
        }
    }
}