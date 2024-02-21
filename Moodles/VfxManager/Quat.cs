﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodles.VfxManager;
[StructLayout(LayoutKind.Sequential)]
public struct Quat
{
    public float X;
    public float Z;
    public float Y;
    public float W;

    public static implicit operator System.Numerics.Vector4(Quat pos) => new(pos.X, pos.Y, pos.Z, pos.W);
}