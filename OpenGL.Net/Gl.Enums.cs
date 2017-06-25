
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

// Disable "'token' is obsolete" warnings
#pragma warning disable 618

using System;

namespace OpenGL
{
	/// <summary>
	/// Strongly typed enumeration AccumOp.
	/// </summary>
	public enum AccumOp
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Accum = Gl.ACCUM,

		/// <summary>
		/// Strongly typed for value GL_LOAD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Load = Gl.LOAD,

		/// <summary>
		/// Strongly typed for value GL_RETURN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Return = Gl.RETURN,

		/// <summary>
		/// Strongly typed for value GL_MULT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Mult = Gl.MULT,

		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Add = Gl.ADD,

	}

	/// <summary>
	/// Strongly typed enumeration AtomicCounterBufferPName.
	/// </summary>
	public enum AtomicCounterBufferPName
	{
		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferActiveAtomicCounters = Gl.ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferActiveAtomicCounterIndices = Gl.ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_BINDING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferBinding = Gl.ATOMIC_COUNTER_BUFFER_BINDING,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferDataSize = Gl.ATOMIC_COUNTER_BUFFER_DATA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByVertexShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByTessControlShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByTessEvaluationShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByGeometryShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByFragmentShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		AtomicCounterBufferReferencedByComputeShader = Gl.ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER,

	}

	/// <summary>
	/// Strongly typed enumeration AttribMask.
	/// </summary>
	[Flags()]
	public enum AttribMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumBufferBit = Gl.ACCUM_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ALL_ATTRIB_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AllAttribBits = Gl.ALL_ATTRIB_BITS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		ColorBufferBit = Gl.COLOR_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentBit = Gl.CURRENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthBufferBit = Gl.DEPTH_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ENABLE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EnableBit = Gl.ENABLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_EVAL_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EvalBit = Gl.EVAL_BIT,

		/// <summary>
		/// Strongly typed for value GL_FOG_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogBit = Gl.FOG_BIT,

		/// <summary>
		/// Strongly typed for value GL_HINT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		HintBit = Gl.HINT_BIT,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightingBit = Gl.LIGHTING_BIT,

		/// <summary>
		/// Strongly typed for value GL_LINE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineBit = Gl.LINE_BIT,

		/// <summary>
		/// Strongly typed for value GL_LIST_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ListBit = Gl.LIST_BIT,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_BIT, GL_MULTISAMPLE_BIT_3DFX, GL_MULTISAMPLE_BIT_ARB, GL_MULTISAMPLE_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_3DFX_multisample")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MultisampleBit = Gl.MULTISAMPLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MODE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelModeBit = Gl.PIXEL_MODE_BIT,

		/// <summary>
		/// Strongly typed for value GL_POINT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointBit = Gl.POINT_BIT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PolygonBit = Gl.POLYGON_BIT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PolygonStippleBit = Gl.POLYGON_STIPPLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ScissorBit = Gl.SCISSOR_BIT,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilBufferBit = Gl.STENCIL_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureBit = Gl.TEXTURE_BIT,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TransformBit = Gl.TRANSFORM_BIT,

		/// <summary>
		/// Strongly typed for value GL_VIEWPORT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ViewportBit = Gl.VIEWPORT_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration AttributeType.
	/// </summary>
	public enum AttributeType
	{
		/// <summary>
		/// Strongly typed for value GL_FLOAT_VEC2, GL_FLOAT_VEC2_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatVec2 = Gl.FLOAT_VEC2,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_VEC3, GL_FLOAT_VEC3_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatVec3 = Gl.FLOAT_VEC3,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_VEC4, GL_FLOAT_VEC4_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatVec4 = Gl.FLOAT_VEC4,

		/// <summary>
		/// Strongly typed for value GL_INT_VEC2, GL_INT_VEC2_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		IntVec2 = Gl.INT_VEC2,

		/// <summary>
		/// Strongly typed for value GL_INT_VEC3, GL_INT_VEC3_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		IntVec3 = Gl.INT_VEC3,

		/// <summary>
		/// Strongly typed for value GL_INT_VEC4, GL_INT_VEC4_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		IntVec4 = Gl.INT_VEC4,

		/// <summary>
		/// Strongly typed for value GL_BOOL, GL_BOOL_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Bool = Gl.BOOL,

		/// <summary>
		/// Strongly typed for value GL_BOOL_VEC2, GL_BOOL_VEC2_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		BoolVec2 = Gl.BOOL_VEC2,

		/// <summary>
		/// Strongly typed for value GL_BOOL_VEC3, GL_BOOL_VEC3_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		BoolVec3 = Gl.BOOL_VEC3,

		/// <summary>
		/// Strongly typed for value GL_BOOL_VEC4, GL_BOOL_VEC4_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		BoolVec4 = Gl.BOOL_VEC4,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT2, GL_FLOAT_MAT2_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatMat2 = Gl.FLOAT_MAT2,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT3, GL_FLOAT_MAT3_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatMat3 = Gl.FLOAT_MAT3,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT4, GL_FLOAT_MAT4_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		FloatMat4 = Gl.FLOAT_MAT4,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_1D, GL_SAMPLER_1D_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Sampler1d = Gl.SAMPLER_1D,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_2D, GL_SAMPLER_2D_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Sampler2d = Gl.SAMPLER_2D,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_3D, GL_SAMPLER_3D_ARB, GL_SAMPLER_3D_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		Sampler3d = Gl.SAMPLER_3D,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_CUBE, GL_SAMPLER_CUBE_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		SamplerCube = Gl.SAMPLER_CUBE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_1D_SHADOW, GL_SAMPLER_1D_SHADOW_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Sampler1dShadow = Gl.SAMPLER_1D_SHADOW,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_2D_SHADOW, GL_SAMPLER_2D_SHADOW_ARB, GL_SAMPLER_2D_SHADOW_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		Sampler2dShadow = Gl.SAMPLER_2D_SHADOW,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_2D_RECT, GL_SAMPLER_2D_RECT_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Sampler2dRect = Gl.SAMPLER_2D_RECT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER_2D_RECT_SHADOW, GL_SAMPLER_2D_RECT_SHADOW_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_shader_objects")]
		Sampler2dRectShadow = Gl.SAMPLER_2D_RECT_SHADOW,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT2x3, GL_FLOAT_MAT2x3_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat2x3 = Gl.FLOAT_MAT2x3,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT2x4, GL_FLOAT_MAT2x4_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat2x4 = Gl.FLOAT_MAT2x4,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT3x2, GL_FLOAT_MAT3x2_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat3x2 = Gl.FLOAT_MAT3x2,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT3x4, GL_FLOAT_MAT3x4_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat3x4 = Gl.FLOAT_MAT3x4,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT4x2, GL_FLOAT_MAT4x2_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat4x2 = Gl.FLOAT_MAT4x2,

		/// <summary>
		/// Strongly typed for value GL_FLOAT_MAT4x3, GL_FLOAT_MAT4x3_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_non_square_matrices", Api = "gles2")]
		FloatMat4x3 = Gl.FLOAT_MAT4x3,

	}

	/// <summary>
	/// Strongly typed enumeration AlphaFunction.
	/// </summary>
	public enum AlphaFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration BlendEquationMode.
	/// </summary>
	public enum BlendEquationMode
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_MAX_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_blend_alpha_minmax")]
		AlphaMaxSgix = Gl.ALPHA_MAX_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_MIN_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_blend_alpha_minmax")]
		AlphaMinSgix = Gl.ALPHA_MIN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FUNC_ADD_EXT, GL_FUNC_ADD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		FuncAdd = Gl.FUNC_ADD,

		/// <summary>
		/// Strongly typed for value GL_FUNC_REVERSE_SUBTRACT_EXT, GL_FUNC_REVERSE_SUBTRACT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_subtract")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		FuncReverseSubtract = Gl.FUNC_REVERSE_SUBTRACT,

		/// <summary>
		/// Strongly typed for value GL_FUNC_SUBTRACT_EXT, GL_FUNC_SUBTRACT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_subtract")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		FuncSubtract = Gl.FUNC_SUBTRACT,

		/// <summary>
		/// Strongly typed for value GL_LOGIC_OP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LogicOp = Gl.LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_MAX_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		Max = Gl.MAX,

		/// <summary>
		/// Strongly typed for value GL_MIN_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		Min = Gl.MIN,

	}

	/// <summary>
	/// Strongly typed enumeration BlendingFactor.
	/// </summary>
	public enum BlendingFactor
	{
		/// <summary>
		/// Strongly typed for value GL_ZERO.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		Zero = Gl.ZERO,

		/// <summary>
		/// Strongly typed for value GL_ONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		One = Gl.ONE,

		/// <summary>
		/// Strongly typed for value GL_SRC_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		SrcColor = Gl.SRC_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_SRC_COLOR, GL_ONE_MINUS_SRC_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		OneMinusSrcColor = Gl.ONE_MINUS_SRC_COLOR,

		/// <summary>
		/// Strongly typed for value GL_DST_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		DstColor = Gl.DST_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_DST_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		OneMinusDstColor = Gl.ONE_MINUS_DST_COLOR,

		/// <summary>
		/// Strongly typed for value GL_SRC_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		SrcAlpha = Gl.SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		OneMinusSrcAlpha = Gl.ONE_MINUS_SRC_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_DST_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		DstAlpha = Gl.DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_DST_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		OneMinusDstAlpha = Gl.ONE_MINUS_DST_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		ConstantColor = Gl.CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		OneMinusConstantColor = Gl.ONE_MINUS_CONSTANT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		ConstantAlpha = Gl.CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_ONE_MINUS_CONSTANT_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_color")]
		OneMinusConstantAlpha = Gl.ONE_MINUS_CONSTANT_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_SRC_ALPHA_SATURATE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		SrcAlphaSaturate = Gl.SRC_ALPHA_SATURATE,

		/// <summary>
		/// Strongly typed for value GL_SRC1_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_blend_func_extended", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		Src1Color = Gl.SRC1_COLOR,

		/// <summary>
		/// Strongly typed for value GL_SRC1_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_env_combine")]
		[RequiredByFeature("GL_EXT_texture_env_combine")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Source1Alpha = Gl.SOURCE1_ALPHA,

	}

	/// <summary>
	/// Strongly typed enumeration BlitFramebufferFilter.
	/// </summary>
	public enum BlitFramebufferFilter
	{
		/// <summary>
		/// Strongly typed for value GL_NEAREST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Nearest = Gl.NEAREST,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Linear = Gl.LINEAR,

	}

	/// <summary>
	/// Strongly typed enumeration Boolean.
	/// </summary>
	public enum Boolean
	{
		/// <summary>
		/// Strongly typed for value GL_FALSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		False = Gl.FALSE,

		/// <summary>
		/// Strongly typed for value GL_TRUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		True = Gl.TRUE,

	}

	/// <summary>
	/// Strongly typed enumeration Buffer.
	/// </summary>
	public enum Buffer
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Color = Gl.COLOR,

		/// <summary>
		/// Strongly typed for value GL_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Depth = Gl.DEPTH,

		/// <summary>
		/// Strongly typed for value GL_STENCIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Stencil = Gl.STENCIL,

	}

	/// <summary>
	/// Strongly typed enumeration BufferAccess.
	/// </summary>
	public enum BufferAccess
	{
		/// <summary>
		/// Strongly typed for value GL_READ_ONLY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		ReadOnly = Gl.READ_ONLY,

		/// <summary>
		/// Strongly typed for value GL_WRITE_ONLY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_NV_shader_buffer_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		WriteOnly = Gl.WRITE_ONLY,

		/// <summary>
		/// Strongly typed for value GL_READ_WRITE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_NV_shader_buffer_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		ReadWrite = Gl.READ_WRITE,

	}

	/// <summary>
	/// Strongly typed enumeration BufferTarget.
	/// </summary>
	public enum BufferTarget
	{
		/// <summary>
		/// Strongly typed for value GL_ARRAY_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		ArrayBuffer = Gl.ARRAY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		AtomicCounterBuffer = Gl.ATOMIC_COUNTER_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_COPY_READ_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_copy_buffer", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_copy_buffer", Api = "gles2")]
		CopyReadBuffer = Gl.COPY_READ_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_COPY_WRITE_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_copy_buffer", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_copy_buffer", Api = "gles2")]
		CopyWriteBuffer = Gl.COPY_WRITE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_DISPATCH_INDIRECT_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		DispatchIndirectBuffer = Gl.DISPATCH_INDIRECT_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRAW_INDIRECT_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_draw_indirect", Api = "gl|glcore")]
		DrawIndirectBuffer = Gl.DRAW_INDIRECT_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_ELEMENT_ARRAY_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		ElementArrayBuffer = Gl.ELEMENT_ARRAY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_PACK_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_pixel_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_pixel_buffer_object")]
		PixelPackBuffer = Gl.PIXEL_PACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_UNPACK_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_pixel_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_pixel_buffer_object")]
		PixelUnpackBuffer = Gl.PIXEL_UNPACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_QUERY_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_query_buffer_object")]
		QueryBuffer = Gl.QUERY_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_SHADER_STORAGE_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		ShaderStorageBuffer = Gl.SHADER_STORAGE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_buffer", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_buffer_object")]
		[RequiredByFeature("GL_OES_texture_buffer", Api = "gles2")]
		TextureBuffer = Gl.TEXTURE_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackBuffer = Gl.TRANSFORM_FEEDBACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBuffer = Gl.UNIFORM_BUFFER,

	}

	/// <summary>
	/// Strongly typed enumeration BufferUsage.
	/// </summary>
	public enum BufferUsage
	{
		/// <summary>
		/// Strongly typed for value GL_STREAM_DRAW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StreamDraw = Gl.STREAM_DRAW,

		/// <summary>
		/// Strongly typed for value GL_STREAM_READ.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StreamRead = Gl.STREAM_READ,

		/// <summary>
		/// Strongly typed for value GL_STREAM_COPY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StreamCopy = Gl.STREAM_COPY,

		/// <summary>
		/// Strongly typed for value GL_STATIC_DRAW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StaticDraw = Gl.STATIC_DRAW,

		/// <summary>
		/// Strongly typed for value GL_STATIC_READ.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StaticRead = Gl.STATIC_READ,

		/// <summary>
		/// Strongly typed for value GL_STATIC_COPY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		StaticCopy = Gl.STATIC_COPY,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_DRAW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		DynamicDraw = Gl.DYNAMIC_DRAW,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_READ.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		DynamicRead = Gl.DYNAMIC_READ,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_COPY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		DynamicCopy = Gl.DYNAMIC_COPY,

	}

	/// <summary>
	/// Strongly typed enumeration ClearBufferMask.
	/// </summary>
	[Flags()]
	public enum ClearBufferMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumBufferBit = Gl.ACCUM_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		ColorBufferBit = Gl.COLOR_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COVERAGE_BUFFER_BIT_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_coverage_sample", Api = "gles2")]
		CoverageBufferBitNv = Gl.COVERAGE_BUFFER_BIT_NV,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthBufferBit = Gl.DEPTH_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BUFFER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilBufferBit = Gl.STENCIL_BUFFER_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ClientAttribMask.
	/// </summary>
	[Flags()]
	public enum ClientAttribMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CLIENT_ALL_ATTRIB_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClientAllAttribBits = Gl.CLIENT_ALL_ATTRIB_BITS,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_PIXEL_STORE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClientPixelStoreBit = Gl.CLIENT_PIXEL_STORE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_VERTEX_ARRAY_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClientVertexArrayBit = Gl.CLIENT_VERTEX_ARRAY_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ClipControlOrigin.
	/// </summary>
	public enum ClipControlOrigin
	{
		/// <summary>
		/// Strongly typed for value GL_LOWER_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		LowerLeft = Gl.LOWER_LEFT,

		/// <summary>
		/// Strongly typed for value GL_UPPER_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		UpperLeft = Gl.UPPER_LEFT,

	}

	/// <summary>
	/// Strongly typed enumeration ClipControlDepth.
	/// </summary>
	public enum ClipControlDepth
	{
		/// <summary>
		/// Strongly typed for value GL_NEGATIVE_ONE_TO_ONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		NegativeOneToOne = Gl.NEGATIVE_ONE_TO_ONE,

		/// <summary>
		/// Strongly typed for value GL_ZERO_TO_ONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_clip_control", Api = "gl|glcore")]
		ZeroToOne = Gl.ZERO_TO_ONE,

	}

	/// <summary>
	/// Strongly typed enumeration ClipPlaneName.
	/// </summary>
	public enum ClipPlaneName
	{
		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE0, GL_CLIP_PLANE0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE1, GL_CLIP_PLANE1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE2, GL_CLIP_PLANE2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE3, GL_CLIP_PLANE3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE4, GL_CLIP_PLANE4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE5, GL_CLIP_PLANE5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
		ClipDistance6 = Gl.CLIP_DISTANCE6,

		/// <summary>
		/// Strongly typed for value GL_CLIP_DISTANCE7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_APPLE_clip_distance", Api = "gles2")]
		ClipDistance7 = Gl.CLIP_DISTANCE7,

	}

	/// <summary>
	/// Strongly typed enumeration ColorBuffer.
	/// </summary>
	public enum ColorBuffer
	{
		/// <summary>
		/// Strongly typed for value GL_NONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		None = Gl.NONE,

		/// <summary>
		/// Strongly typed for value GL_FRONT_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontLeft = Gl.FRONT_LEFT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontRight = Gl.FRONT_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_BACK_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackLeft = Gl.BACK_LEFT,

		/// <summary>
		/// Strongly typed for value GL_BACK_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackRight = Gl.BACK_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Left = Gl.LEFT,

		/// <summary>
		/// Strongly typed for value GL_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Right = Gl.RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		ColorAttachment0 = Gl.COLOR_ATTACHMENT0,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment1 = Gl.COLOR_ATTACHMENT1,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment2 = Gl.COLOR_ATTACHMENT2,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment3 = Gl.COLOR_ATTACHMENT3,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment4 = Gl.COLOR_ATTACHMENT4,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment5 = Gl.COLOR_ATTACHMENT5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment6 = Gl.COLOR_ATTACHMENT6,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment7 = Gl.COLOR_ATTACHMENT7,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment8 = Gl.COLOR_ATTACHMENT8,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT9.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment9 = Gl.COLOR_ATTACHMENT9,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT10.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment10 = Gl.COLOR_ATTACHMENT10,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT11.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment11 = Gl.COLOR_ATTACHMENT11,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment12 = Gl.COLOR_ATTACHMENT12,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT13.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment13 = Gl.COLOR_ATTACHMENT13,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT14.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment14 = Gl.COLOR_ATTACHMENT14,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT15.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment15 = Gl.COLOR_ATTACHMENT15,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment16 = Gl.COLOR_ATTACHMENT16,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT17.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment17 = Gl.COLOR_ATTACHMENT17,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT18.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment18 = Gl.COLOR_ATTACHMENT18,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT19.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment19 = Gl.COLOR_ATTACHMENT19,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT20.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment20 = Gl.COLOR_ATTACHMENT20,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT21.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment21 = Gl.COLOR_ATTACHMENT21,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT22.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment22 = Gl.COLOR_ATTACHMENT22,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT23.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment23 = Gl.COLOR_ATTACHMENT23,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT24.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment24 = Gl.COLOR_ATTACHMENT24,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT25.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment25 = Gl.COLOR_ATTACHMENT25,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT26.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment26 = Gl.COLOR_ATTACHMENT26,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT27.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment27 = Gl.COLOR_ATTACHMENT27,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT28.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment28 = Gl.COLOR_ATTACHMENT28,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT29.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment29 = Gl.COLOR_ATTACHMENT29,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT30.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment30 = Gl.COLOR_ATTACHMENT30,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT31.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment31 = Gl.COLOR_ATTACHMENT31,

	}

	/// <summary>
	/// Strongly typed enumeration ColorMaterialFace.
	/// </summary>
	public enum ColorMaterialFace
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration ColorMaterialParameter.
	/// </summary>
	public enum ColorMaterialParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_AMBIENT_AND_DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AmbientAndDiffuse = Gl.AMBIENT_AND_DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_EMISSION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Emission = Gl.EMISSION,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Specular = Gl.SPECULAR,

	}

	/// <summary>
	/// Strongly typed enumeration ColorPointerType.
	/// </summary>
	public enum ColorPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration ColorTableParameterPName.
	/// </summary>
	public enum ColorTableParameterPName
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BIAS, GL_COLOR_TABLE_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableBias = Gl.COLOR_TABLE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SCALE, GL_COLOR_TABLE_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableScale = Gl.COLOR_TABLE_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration ColorTableTarget.
	/// </summary>
	public enum ColorTableTarget
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE, GL_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE, GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE, GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_COLOR_TABLE, GL_PROXY_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ProxyColorTable = Gl.PROXY_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE, GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ProxyPostColorMatrixColorTable = Gl.PROXY_POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_POST_CONVOLUTION_COLOR_TABLE, GL_PROXY_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ProxyPostConvolutionColorTable = Gl.PROXY_POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_SGI_texture_color_table")]
		ProxyTextureColorTableSgi = Gl.PROXY_TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_SGI_texture_color_table")]
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

	}

	/// <summary>
	/// Strongly typed enumeration ContextFlagMask.
	/// </summary>
	[Flags()]
	public enum ContextFlagMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_DEBUG_BIT, GL_CONTEXT_FLAG_DEBUG_BIT_KHR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		ContextFlagDebugBit = Gl.CONTEXT_FLAG_DEBUG_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		ContextFlagForwardCompatibleBit = Gl.CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		ContextFlagRobustAccessBit = Gl.CONTEXT_FLAG_ROBUST_ACCESS_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_protected_textures", Api = "gles2")]
		ContextFlagProtectedContentBitExt = Gl.CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration ContextProfileMask.
	/// </summary>
	[Flags()]
	public enum ContextProfileMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CONTEXT_COMPATIBILITY_PROFILE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		ContextCompatibilityProfileBit = Gl.CONTEXT_COMPATIBILITY_PROFILE_BIT,

		/// <summary>
		/// Strongly typed for value GL_CONTEXT_CORE_PROFILE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		ContextCoreProfileBit = Gl.CONTEXT_CORE_PROFILE_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionBorderModeEXT.
	/// </summary>
	public enum ConvolutionBorderModeEXT
	{
		/// <summary>
		/// Strongly typed for value GL_REDUCE, GL_REDUCE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Reduce = Gl.REDUCE,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionParameterEXT.
	/// </summary>
	public enum ConvolutionParameterEXT
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_BORDER_MODE, GL_CONVOLUTION_BORDER_MODE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionBorderMode = Gl.CONVOLUTION_BORDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_BIAS, GL_CONVOLUTION_FILTER_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionFilterBias = Gl.CONVOLUTION_FILTER_BIAS,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_SCALE, GL_CONVOLUTION_FILTER_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionFilterScale = Gl.CONVOLUTION_FILTER_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration ConvolutionTarget.
	/// </summary>
	public enum ConvolutionTarget
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D, GL_CONVOLUTION_1D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D, GL_CONVOLUTION_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution2d = Gl.CONVOLUTION_2D,

	}

	/// <summary>
	/// Strongly typed enumeration CullFaceMode.
	/// </summary>
	public enum CullFaceMode
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration DataType.
	/// </summary>
	[Flags()]
	public enum DataType : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration DebugSource.
	/// </summary>
	public enum DebugSource
	{
		/// <summary>
		/// Strongly typed for value GL_DEBUG_SOURCE_API.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSourceApi = Gl.DEBUG_SOURCE_API,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SOURCE_SHADER_COMPILER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSourceShaderCompiler = Gl.DEBUG_SOURCE_SHADER_COMPILER,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SOURCE_THIRD_PARTY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSourceThirdParty = Gl.DEBUG_SOURCE_THIRD_PARTY,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SOURCE_APPLICATION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSourceApplication = Gl.DEBUG_SOURCE_APPLICATION,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SOURCE_OTHER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSourceOther = Gl.DEBUG_SOURCE_OTHER,

		/// <summary>
		/// Strongly typed for value GL_DONT_CARE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DontCare = Gl.DONT_CARE,

	}

	/// <summary>
	/// Strongly typed enumeration DebugType.
	/// </summary>
	public enum DebugType
	{
		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_ERROR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypeError = Gl.DEBUG_TYPE_ERROR,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_DEPRECATED_BEHAVIOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypeDeprecatedBehavior = Gl.DEBUG_TYPE_DEPRECATED_BEHAVIOR,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_UNDEFINED_BEHAVIOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypeUndefinedBehavior = Gl.DEBUG_TYPE_UNDEFINED_BEHAVIOR,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_PORTABILITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypePortability = Gl.DEBUG_TYPE_PORTABILITY,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_PERFORMANCE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypePerformance = Gl.DEBUG_TYPE_PERFORMANCE,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_MARKER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypeMarker = Gl.DEBUG_TYPE_MARKER,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_PUSH_GROUP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypePushGroup = Gl.DEBUG_TYPE_PUSH_GROUP,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_POP_GROUP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypePopGroup = Gl.DEBUG_TYPE_POP_GROUP,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_TYPE_OTHER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugTypeOther = Gl.DEBUG_TYPE_OTHER,

		/// <summary>
		/// Strongly typed for value GL_DONT_CARE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DontCare = Gl.DONT_CARE,

	}

	/// <summary>
	/// Strongly typed enumeration DebugSeverity.
	/// </summary>
	public enum DebugSeverity
	{
		/// <summary>
		/// Strongly typed for value GL_DEBUG_SEVERITY_LOW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSeverityLow = Gl.DEBUG_SEVERITY_LOW,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SEVERITY_MEDIUM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSeverityMedium = Gl.DEBUG_SEVERITY_MEDIUM,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_SEVERITY_HIGH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_AMD_debug_output")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugSeverityHigh = Gl.DEBUG_SEVERITY_HIGH,

		/// <summary>
		/// Strongly typed for value GL_DONT_CARE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DontCare = Gl.DONT_CARE,

	}

	/// <summary>
	/// Strongly typed enumeration DepthFunction.
	/// </summary>
	public enum DepthFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration DrawBufferMode.
	/// </summary>
	public enum DrawBufferMode
	{
		/// <summary>
		/// Strongly typed for value GL_AUX0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux0 = Gl.AUX0,

		/// <summary>
		/// Strongly typed for value GL_AUX1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux1 = Gl.AUX1,

		/// <summary>
		/// Strongly typed for value GL_AUX2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux2 = Gl.AUX2,

		/// <summary>
		/// Strongly typed for value GL_AUX3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux3 = Gl.AUX3,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_BACK_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackLeft = Gl.BACK_LEFT,

		/// <summary>
		/// Strongly typed for value GL_BACK_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackRight = Gl.BACK_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontLeft = Gl.FRONT_LEFT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontRight = Gl.FRONT_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Left = Gl.LEFT,

		/// <summary>
		/// Strongly typed for value GL_NONE, GL_NONE_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		None = Gl.NONE,

		/// <summary>
		/// Strongly typed for value GL_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Right = Gl.RIGHT,

	}

	/// <summary>
	/// Strongly typed enumeration DrawElementsType.
	/// </summary>
	public enum DrawElementsType
	{
		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

	}

	/// <summary>
	/// Strongly typed enumeration EnableCap.
	/// </summary>
	public enum EnableCap
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaTest = Gl.ALPHA_TEST,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncDrawPixelsSgix = Gl.ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_histogram")]
		AsyncHistogramSgix = Gl.ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncReadPixelsSgix = Gl.ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncTexImageSgix = Gl.ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_AUTO_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AutoNormal = Gl.AUTO_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_CALLIGRAPHIC_FRAGMENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_calligraphic_fragment")]
		CalligraphicFragmentSgix = Gl.CALLIGRAPHIC_FRAGMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArray = Gl.COLOR_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_COLOR_LOGIC_OP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		ColorLogicOp = Gl.COLOR_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorMaterial = Gl.COLOR_MATERIAL,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution2d = Gl.CONVOLUTION_2D,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		CullFace = Gl.CULL_FACE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthTest = Gl.DEPTH_TEST,

		/// <summary>
		/// Strongly typed for value GL_DITHER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Dither = Gl.DITHER,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EdgeFlagArray = Gl.EDGE_FLAG_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_FOG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Fog = Gl.FOG,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fog_offset")]
		FogOffsetSgix = Gl.FOG_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentColorMaterialSgix = Gl.FRAGMENT_COLOR_MATERIAL_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT1_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight1Sgix = Gl.FRAGMENT_LIGHT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT2_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight2Sgix = Gl.FRAGMENT_LIGHT2_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT3_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight3Sgix = Gl.FRAGMENT_LIGHT3_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT4_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight4Sgix = Gl.FRAGMENT_LIGHT4_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT5_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight5Sgix = Gl.FRAGMENT_LIGHT5_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT6_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight6Sgix = Gl.FRAGMENT_LIGHT6_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT7_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight7Sgix = Gl.FRAGMENT_LIGHT7_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHTING_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightingSgix = Gl.FRAGMENT_LIGHTING_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		FramezoomSgix = Gl.FRAMEZOOM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexArray = Gl.INDEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_INDEX_LOGIC_OP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexLogicOp = Gl.INDEX_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_INTERLACE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_interlace")]
		InterlaceSgix = Gl.INTERLACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_IR_INSTRUMENT1_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_ir_instrument1")]
		IrInstrument1Sgix = Gl.IR_INSTRUMENT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light7 = Gl.LIGHT7,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Lighting = Gl.LIGHTING,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		LineSmooth = Gl.LINE_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineStipple = Gl.LINE_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Minmax = Gl.MINMAX,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		Multisample = Gl.MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_NORMALIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Normalize = Gl.NORMALIZE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NormalArray = Gl.NORMAL_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEXTURE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		PixelTextureSgis = Gl.PIXEL_TEXTURE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		PixelTexGenSgix = Gl.PIXEL_TEX_GEN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSmooth = Gl.POINT_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FILL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		PolygonOffsetFill = Gl.POLYGON_OFFSET_FILL,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_LINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		PolygonOffsetLine = Gl.POLYGON_OFFSET_LINE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_POINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		PolygonOffsetPoint = Gl.POLYGON_OFFSET_POINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PolygonSmooth = Gl.POLYGON_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PolygonStipple = Gl.POLYGON_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_reference_plane")]
		ReferencePlaneSgix = Gl.REFERENCE_PLANE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESCALE_NORMAL_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_rescale_normal")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RescaleNormal = Gl.RESCALE_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_MASK_SGIS.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleAlphaToMaskExt = Gl.SAMPLE_ALPHA_TO_MASK_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_ONE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleAlphaToOne = Gl.SAMPLE_ALPHA_TO_ONE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleMaskSgis = Gl.SAMPLE_MASK_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		ScissorTest = Gl.SCISSOR_TEST,

		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Separable2d = Gl.SEPARABLE_2D,

		/// <summary>
		/// Strongly typed for value GL_SHARED_TEXTURE_PALETTE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_shared_texture_palette")]
		SharedTexturePaletteExt = Gl.SHARED_TEXTURE_PALETTE_EXT,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		SpriteSgix = Gl.SPRITE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilTest = Gl.STENCIL_TEST,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_SGI_texture_color_table")]
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArray = Gl.TEXTURE_COORD_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_Q.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenQ = Gl.TEXTURE_GEN_Q,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenR = Gl.TEXTURE_GEN_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenS = Gl.TEXTURE_GEN_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenT = Gl.TEXTURE_GEN_T,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArray = Gl.VERTEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_SRGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_sRGB", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_sRGB")]
		[RequiredByFeature("GL_EXT_sRGB_write_control", Api = "gles2")]
		FramebufferSrgb = Gl.FRAMEBUFFER_SRGB,

		/// <summary>
		/// Strongly typed for value GL_PRIMITIVE_RESTART.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		PrimitiveRestart = Gl.PRIMITIVE_RESTART,

		/// <summary>
		/// Strongly typed for value GL_PRIMITIVE_RESTART_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_primitive_restart")]
		PrimitiveRestartNv = Gl.PRIMITIVE_RESTART_NV,

		/// <summary>
		/// Strongly typed for value GL_RASTERIZER_DISCARD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		RasterizerDiscard = Gl.RASTERIZER_DISCARD,

	}

	/// <summary>
	/// Strongly typed enumeration ErrorCode.
	/// </summary>
	public enum ErrorCode
	{
		/// <summary>
		/// Strongly typed for value GL_INVALID_ENUM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		InvalidEnum = Gl.INVALID_ENUM,

		/// <summary>
		/// Strongly typed for value GL_INVALID_FRAMEBUFFER_OPERATION, GL_INVALID_FRAMEBUFFER_OPERATION_EXT, 
		/// GL_INVALID_FRAMEBUFFER_OPERATION_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		InvalidFramebufferOperation = Gl.INVALID_FRAMEBUFFER_OPERATION,

		/// <summary>
		/// Strongly typed for value GL_INVALID_OPERATION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		InvalidOperation = Gl.INVALID_OPERATION,

		/// <summary>
		/// Strongly typed for value GL_INVALID_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		InvalidValue = Gl.INVALID_VALUE,

		/// <summary>
		/// Strongly typed for value GL_NO_ERROR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		NoError = Gl.NO_ERROR,

		/// <summary>
		/// Strongly typed for value GL_OUT_OF_MEMORY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		OutOfMemory = Gl.OUT_OF_MEMORY,

		/// <summary>
		/// Strongly typed for value GL_STACK_OVERFLOW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		StackOverflow = Gl.STACK_OVERFLOW,

		/// <summary>
		/// Strongly typed for value GL_STACK_UNDERFLOW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		StackUnderflow = Gl.STACK_UNDERFLOW,

		/// <summary>
		/// Strongly typed for value GL_TABLE_TOO_LARGE, GL_TABLE_TOO_LARGE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		TableTooLarge = Gl.TABLE_TOO_LARGE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_TOO_LARGE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		TextureTooLargeExt = Gl.TEXTURE_TOO_LARGE_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration EvaluatorParameterName.
	/// </summary>
	public enum EvaluatorParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_COEFF.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Coeff = Gl.COEFF,

		/// <summary>
		/// Strongly typed for value GL_ORDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Order = Gl.ORDER,

		/// <summary>
		/// Strongly typed for value GL_DOMAIN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Domain = Gl.DOMAIN,

	}

	/// <summary>
	/// Strongly typed enumeration EvaluatorTarget.
	/// </summary>
	public enum EvaluatorTarget
	{
		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_DEFORMATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		GeometryDeformationSgix = Gl.GEOMETRY_DEFORMATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEFORMATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		TextureDeformationSgix = Gl.TEXTURE_DEFORMATION_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration ExternalHandleType.
	/// </summary>
	public enum ExternalHandleType
	{
		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_OPAQUE_FD_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_fd", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_fd", Api = "gl|gles2")]
		HandleTypeOpaqueFdExt = Gl.HANDLE_TYPE_OPAQUE_FD_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_OPAQUE_WIN32_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		HandleTypeOpaqueWin32Ext = Gl.HANDLE_TYPE_OPAQUE_WIN32_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		HandleTypeOpaqueWin32KmtExt = Gl.HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		HandleTypeD3d12TilepoolExt = Gl.HANDLE_TYPE_D3D12_TILEPOOL_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_D3D12_RESOURCE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		HandleTypeD3d12ResourceExt = Gl.HANDLE_TYPE_D3D12_RESOURCE_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_D3D11_IMAGE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		HandleTypeD3d11ImageExt = Gl.HANDLE_TYPE_D3D11_IMAGE_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		HandleTypeD3d11ImageKmtExt = Gl.HANDLE_TYPE_D3D11_IMAGE_KMT_EXT,

		/// <summary>
		/// Strongly typed for value GL_HANDLE_TYPE_D3D12_FENCE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		HandleTypeD3d12FenceExt = Gl.HANDLE_TYPE_D3D12_FENCE_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration FeedbackType.
	/// </summary>
	public enum FeedbackType
	{
		/// <summary>
		/// Strongly typed for value GL_2D.
		/// </summary>
		_2d = Gl._2D,

		/// <summary>
		/// Strongly typed for value GL_3D.
		/// </summary>
		_3d = Gl._3D,

		/// <summary>
		/// Strongly typed for value GL_3D_COLOR.
		/// </summary>
		_3dColor = Gl._3D_COLOR,

		/// <summary>
		/// Strongly typed for value GL_3D_COLOR_TEXTURE.
		/// </summary>
		_3dColorTexture = Gl._3D_COLOR_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_4D_COLOR_TEXTURE.
		/// </summary>
		_4dColorTexture = Gl._4D_COLOR_TEXTURE,

	}

	/// <summary>
	/// Strongly typed enumeration FeedBackToken.
	/// </summary>
	public enum FeedBackToken
	{
		/// <summary>
		/// Strongly typed for value GL_BITMAP_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BitmapToken = Gl.BITMAP_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_COPY_PIXEL_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CopyPixelToken = Gl.COPY_PIXEL_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_DRAW_PIXEL_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DrawPixelToken = Gl.DRAW_PIXEL_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_LINE_RESET_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineResetToken = Gl.LINE_RESET_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_LINE_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineToken = Gl.LINE_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_PASS_THROUGH_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PassThroughToken = Gl.PASS_THROUGH_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_POINT_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointToken = Gl.POINT_TOKEN,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_TOKEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PolygonToken = Gl.POLYGON_TOKEN,

	}

	/// <summary>
	/// Strongly typed enumeration FenceSyncCondition.
	/// </summary>
	public enum FenceSyncCondition
	{
		/// <summary>
		/// Strongly typed for value GL_SYNC_GPU_COMMANDS_COMPLETE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		SyncGpuCommandsComplete = Gl.SYNC_GPU_COMMANDS_COMPLETE,

	}

	/// <summary>
	/// Strongly typed enumeration FfdMaskSGIX.
	/// </summary>
	[Flags()]
	public enum FfdMaskSGIX : uint
	{
	}

	/// <summary>
	/// Strongly typed enumeration FfdTargetSGIX.
	/// </summary>
	public enum FfdTargetSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_DEFORMATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		GeometryDeformationSgix = Gl.GEOMETRY_DEFORMATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEFORMATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		TextureDeformationSgix = Gl.TEXTURE_DEFORMATION_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration FogCoordinatePointerType.
	/// </summary>
	public enum FogCoordinatePointerType
	{
		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

	}

	/// <summary>
	/// Strongly typed enumeration FogMode.
	/// </summary>
	public enum FogMode
	{
		/// <summary>
		/// Strongly typed for value GL_EXP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Exp = Gl.EXP,

		/// <summary>
		/// Strongly typed for value GL_EXP2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Exp2 = Gl.EXP2,

		/// <summary>
		/// Strongly typed for value GL_FOG_FUNC_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		FogFuncSgis = Gl.FOG_FUNC_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Linear = Gl.LINEAR,

	}

	/// <summary>
	/// Strongly typed enumeration FogPName.
	/// </summary>
	public enum FogPName
	{
		/// <summary>
		/// Strongly typed for value GL_FOG_COORD_SRC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_fog_coord")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogCoordinateSource = Gl.FOG_COORDINATE_SOURCE,

		/// <summary>
		/// Strongly typed for value GL_FOG_DENSITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogDensity = Gl.FOG_DENSITY,

		/// <summary>
		/// Strongly typed for value GL_FOG_END.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogEnd = Gl.FOG_END,

		/// <summary>
		/// Strongly typed for value GL_FOG_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogIndex = Gl.FOG_INDEX,

		/// <summary>
		/// Strongly typed for value GL_FOG_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogMode = Gl.FOG_MODE,

		/// <summary>
		/// Strongly typed for value GL_FOG_START.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogStart = Gl.FOG_START,

	}

	/// <summary>
	/// Strongly typed enumeration FogParameter.
	/// </summary>
	public enum FogParameter
	{
		/// <summary>
		/// Strongly typed for value GL_FOG_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogColor = Gl.FOG_COLOR,

		/// <summary>
		/// Strongly typed for value GL_FOG_DENSITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogDensity = Gl.FOG_DENSITY,

		/// <summary>
		/// Strongly typed for value GL_FOG_END.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogEnd = Gl.FOG_END,

		/// <summary>
		/// Strongly typed for value GL_FOG_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogIndex = Gl.FOG_INDEX,

		/// <summary>
		/// Strongly typed for value GL_FOG_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogMode = Gl.FOG_MODE,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_VALUE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fog_offset")]
		FogOffsetValueSgix = Gl.FOG_OFFSET_VALUE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_START.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogStart = Gl.FOG_START,

	}

	/// <summary>
	/// Strongly typed enumeration FragmentLightModelParameterSGIX.
	/// </summary>
	public enum FragmentLightModelParameterSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelAmbientSgix = Gl.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelLocalViewerSgix = Gl.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelNormalInterpolationSgix = Gl.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelTwoSideSgix = Gl.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration FragmentOpATI.
	/// </summary>
	public enum FragmentOpATI
	{
		/// <summary>
		/// Strongly typed for value GL_MOV_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		MovAti = Gl.MOV_ATI,

		/// <summary>
		/// Strongly typed for value GL_ADD_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		AddAti = Gl.ADD_ATI,

		/// <summary>
		/// Strongly typed for value GL_MUL_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		MulAti = Gl.MUL_ATI,

		/// <summary>
		/// Strongly typed for value GL_SUB_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		SubAti = Gl.SUB_ATI,

		/// <summary>
		/// Strongly typed for value GL_DOT3_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		Dot3Ati = Gl.DOT3_ATI,

		/// <summary>
		/// Strongly typed for value GL_DOT4_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		Dot4Ati = Gl.DOT4_ATI,

		/// <summary>
		/// Strongly typed for value GL_MAD_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		MadAti = Gl.MAD_ATI,

		/// <summary>
		/// Strongly typed for value GL_LERP_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		LerpAti = Gl.LERP_ATI,

		/// <summary>
		/// Strongly typed for value GL_CND_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		CndAti = Gl.CND_ATI,

		/// <summary>
		/// Strongly typed for value GL_CND0_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		Cnd0Ati = Gl.CND0_ATI,

		/// <summary>
		/// Strongly typed for value GL_DOT2_ADD_ATI.
		/// </summary>
		[RequiredByFeature("GL_ATI_fragment_shader")]
		Dot2AddAti = Gl.DOT2_ADD_ATI,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferAttachment.
	/// </summary>
	public enum FramebufferAttachment
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT0, GL_COLOR_ATTACHMENT0_EXT, GL_COLOR_ATTACHMENT0_NV, 
		/// GL_COLOR_ATTACHMENT0_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		ColorAttachment0 = Gl.COLOR_ATTACHMENT0,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT1, GL_COLOR_ATTACHMENT1_EXT, GL_COLOR_ATTACHMENT1_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment1 = Gl.COLOR_ATTACHMENT1,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT2, GL_COLOR_ATTACHMENT2_EXT, GL_COLOR_ATTACHMENT2_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment2 = Gl.COLOR_ATTACHMENT2,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT3, GL_COLOR_ATTACHMENT3_EXT, GL_COLOR_ATTACHMENT3_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment3 = Gl.COLOR_ATTACHMENT3,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT4, GL_COLOR_ATTACHMENT4_EXT, GL_COLOR_ATTACHMENT4_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment4 = Gl.COLOR_ATTACHMENT4,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT5, GL_COLOR_ATTACHMENT5_EXT, GL_COLOR_ATTACHMENT5_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment5 = Gl.COLOR_ATTACHMENT5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT6, GL_COLOR_ATTACHMENT6_EXT, GL_COLOR_ATTACHMENT6_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment6 = Gl.COLOR_ATTACHMENT6,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT7, GL_COLOR_ATTACHMENT7_EXT, GL_COLOR_ATTACHMENT7_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment7 = Gl.COLOR_ATTACHMENT7,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT8, GL_COLOR_ATTACHMENT8_EXT, GL_COLOR_ATTACHMENT8_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment8 = Gl.COLOR_ATTACHMENT8,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT9, GL_COLOR_ATTACHMENT9_EXT, GL_COLOR_ATTACHMENT9_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment9 = Gl.COLOR_ATTACHMENT9,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT10, GL_COLOR_ATTACHMENT10_EXT, GL_COLOR_ATTACHMENT10_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment10 = Gl.COLOR_ATTACHMENT10,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT11, GL_COLOR_ATTACHMENT11_EXT, GL_COLOR_ATTACHMENT11_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment11 = Gl.COLOR_ATTACHMENT11,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT12, GL_COLOR_ATTACHMENT12_EXT, GL_COLOR_ATTACHMENT12_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment12 = Gl.COLOR_ATTACHMENT12,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT13, GL_COLOR_ATTACHMENT13_EXT, GL_COLOR_ATTACHMENT13_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment13 = Gl.COLOR_ATTACHMENT13,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT14, GL_COLOR_ATTACHMENT14_EXT, GL_COLOR_ATTACHMENT14_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment14 = Gl.COLOR_ATTACHMENT14,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT15, GL_COLOR_ATTACHMENT15_EXT, GL_COLOR_ATTACHMENT15_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment15 = Gl.COLOR_ATTACHMENT15,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment16 = Gl.COLOR_ATTACHMENT16,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT17.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment17 = Gl.COLOR_ATTACHMENT17,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT18.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment18 = Gl.COLOR_ATTACHMENT18,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT19.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment19 = Gl.COLOR_ATTACHMENT19,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT20.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment20 = Gl.COLOR_ATTACHMENT20,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT21.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment21 = Gl.COLOR_ATTACHMENT21,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT22.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment22 = Gl.COLOR_ATTACHMENT22,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT23.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment23 = Gl.COLOR_ATTACHMENT23,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT24.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment24 = Gl.COLOR_ATTACHMENT24,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT25.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment25 = Gl.COLOR_ATTACHMENT25,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT26.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment26 = Gl.COLOR_ATTACHMENT26,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT27.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment27 = Gl.COLOR_ATTACHMENT27,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT28.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment28 = Gl.COLOR_ATTACHMENT28,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT29.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment29 = Gl.COLOR_ATTACHMENT29,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT30.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment30 = Gl.COLOR_ATTACHMENT30,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT31.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment31 = Gl.COLOR_ATTACHMENT31,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_ATTACHMENT, GL_DEPTH_ATTACHMENT_EXT, GL_DEPTH_ATTACHMENT_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		DepthAttachment = Gl.DEPTH_ATTACHMENT,

		/// <summary>
		/// Strongly typed for value GL_MAX_COLOR_ATTACHMENTS, GL_MAX_COLOR_ATTACHMENTS_EXT, GL_MAX_COLOR_ATTACHMENTS_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		MaxColorAttachments = Gl.MAX_COLOR_ATTACHMENTS,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferAttachmentParameterName.
	/// </summary>
	public enum FramebufferAttachmentParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentAlphaSize = Gl.FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentBlueSize = Gl.FRAMEBUFFER_ATTACHMENT_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
		FramebufferAttachmentColorEncoding = Gl.FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		FramebufferAttachmentComponentType = Gl.FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentDepthSize = Gl.FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentGreenSize = Gl.FRAMEBUFFER_ATTACHMENT_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_LAYERED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		FramebufferAttachmentLayered = Gl.FRAMEBUFFER_ATTACHMENT_LAYERED,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_OBJECT_NAME.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferAttachmentObjectName = Gl.FRAMEBUFFER_ATTACHMENT_OBJECT_NAME,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentRedSize = Gl.FRAMEBUFFER_ATTACHMENT_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		FramebufferAttachmentStencilSize = Gl.FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferAttachmentTextureCubeMapFace = Gl.FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferAttachmentTextureLevel = Gl.FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_EXT_texture_array")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		FramebufferAttachmentTextureLayer = Gl.FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferFetchNoncoherent.
	/// </summary>
	public enum FramebufferFetchNoncoherent
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_FETCH_NONCOHERENT_QCOM.
		/// </summary>
		[RequiredByFeature("GL_QCOM_shader_framebuffer_fetch_noncoherent", Api = "gles2")]
		FramebufferFetchNoncoherentQcom = Gl.FRAMEBUFFER_FETCH_NONCOHERENT_QCOM,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferParameterName.
	/// </summary>
	public enum FramebufferParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultWidth = Gl.FRAMEBUFFER_DEFAULT_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultHeight = Gl.FRAMEBUFFER_DEFAULT_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_LAYERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		FramebufferDefaultLayers = Gl.FRAMEBUFFER_DEFAULT_LAYERS,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_SAMPLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultSamples = Gl.FRAMEBUFFER_DEFAULT_SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultFixedSampleLocations = Gl.FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferStatus.
	/// </summary>
	public enum FramebufferStatus
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_COMPLETE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferComplete = Gl.FRAMEBUFFER_COMPLETE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_ATTACHMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferIncompleteAttachment = Gl.FRAMEBUFFER_INCOMPLETE_ATTACHMENT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		FramebufferIncompleteDrawBuffer = Gl.FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		FramebufferIncompleteLayerTargets = Gl.FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferIncompleteMissingAttachment = Gl.FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_MULTISAMPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		FramebufferIncompleteMultisample = Gl.FRAMEBUFFER_INCOMPLETE_MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_INCOMPLETE_READ_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		FramebufferIncompleteReadBuffer = Gl.FRAMEBUFFER_INCOMPLETE_READ_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_UNDEFINED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_surfaceless_context", Api = "gles2")]
		FramebufferUndefined = Gl.FRAMEBUFFER_UNDEFINED,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_UNSUPPORTED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		FramebufferUnsupported = Gl.FRAMEBUFFER_UNSUPPORTED,

	}

	/// <summary>
	/// Strongly typed enumeration FramebufferTarget.
	/// </summary>
	public enum FramebufferTarget
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		Framebuffer = Gl.FRAMEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRAW_FRAMEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		DrawFramebuffer = Gl.DRAW_FRAMEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_READ_FRAMEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_blit", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_blit")]
		[RequiredByFeature("GL_NV_framebuffer_blit", Api = "gles2")]
		ReadFramebuffer = Gl.READ_FRAMEBUFFER,

	}

	/// <summary>
	/// Strongly typed enumeration FrontFaceDirection.
	/// </summary>
	public enum FrontFaceDirection
	{
		/// <summary>
		/// Strongly typed for value GL_CCW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Ccw = Gl.CCW,

		/// <summary>
		/// Strongly typed for value GL_CW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Cw = Gl.CW,

	}

	/// <summary>
	/// Strongly typed enumeration GetColorTableParameterPNameSGI.
	/// </summary>
	public enum GetColorTableParameterPNameSGI
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_ALPHA_SIZE_SGI, GL_COLOR_TABLE_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableAlphaSize = Gl.COLOR_TABLE_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BIAS_SGI, GL_COLOR_TABLE_BIAS.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableBias = Gl.COLOR_TABLE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_BLUE_SIZE_SGI, GL_COLOR_TABLE_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableBlueSize = Gl.COLOR_TABLE_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_FORMAT_SGI, GL_COLOR_TABLE_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableFormat = Gl.COLOR_TABLE_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_GREEN_SIZE_SGI, GL_COLOR_TABLE_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableGreenSize = Gl.COLOR_TABLE_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_INTENSITY_SIZE_SGI, GL_COLOR_TABLE_INTENSITY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableIntensitySize = Gl.COLOR_TABLE_INTENSITY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_LUMINANCE_SIZE_SGI, GL_COLOR_TABLE_LUMINANCE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableLuminanceSize = Gl.COLOR_TABLE_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_RED_SIZE_SGI, GL_COLOR_TABLE_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableRedSize = Gl.COLOR_TABLE_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SCALE_SGI, GL_COLOR_TABLE_SCALE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableScale = Gl.COLOR_TABLE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_WIDTH_SGI, GL_COLOR_TABLE_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTableWidth = Gl.COLOR_TABLE_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration GetConvolutionParameter.
	/// </summary>
	public enum GetConvolutionParameter
	{
		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_BORDER_MODE_EXT, GL_CONVOLUTION_BORDER_MODE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionBorderMode = Gl.CONVOLUTION_BORDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_BIAS_EXT, GL_CONVOLUTION_FILTER_BIAS.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionFilterBias = Gl.CONVOLUTION_FILTER_BIAS,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FILTER_SCALE_EXT, GL_CONVOLUTION_FILTER_SCALE.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionFilterScale = Gl.CONVOLUTION_FILTER_SCALE,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_FORMAT_EXT, GL_CONVOLUTION_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionFormat = Gl.CONVOLUTION_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HEIGHT_EXT, GL_CONVOLUTION_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionHeight = Gl.CONVOLUTION_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_WIDTH_EXT, GL_CONVOLUTION_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		ConvolutionWidth = Gl.CONVOLUTION_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CONVOLUTION_HEIGHT_EXT, GL_MAX_CONVOLUTION_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		MaxConvolutionHeight = Gl.MAX_CONVOLUTION_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_MAX_CONVOLUTION_WIDTH_EXT, GL_MAX_CONVOLUTION_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		MaxConvolutionWidth = Gl.MAX_CONVOLUTION_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_BORDER_COLOR.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_HP_convolution_border_modes")]
		ConvolutionBorderColor = Gl.CONVOLUTION_BORDER_COLOR,

	}

	/// <summary>
	/// Strongly typed enumeration GetFramebufferParameter.
	/// </summary>
	public enum GetFramebufferParameter
	{
		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultWidth = Gl.FRAMEBUFFER_DEFAULT_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultHeight = Gl.FRAMEBUFFER_DEFAULT_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_LAYERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		FramebufferDefaultLayers = Gl.FRAMEBUFFER_DEFAULT_LAYERS,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_SAMPLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultSamples = Gl.FRAMEBUFFER_DEFAULT_SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_no_attachments", Api = "gl|glcore")]
		FramebufferDefaultFixedSampleLocations = Gl.FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS,

		/// <summary>
		/// Strongly typed for value GL_DOUBLEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Doublebuffer = Gl.DOUBLEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_IMPLEMENTATION_COLOR_READ_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		ImplementationColorReadFormat = Gl.IMPLEMENTATION_COLOR_READ_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_IMPLEMENTATION_COLOR_READ_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_read_format", Api = "gl|gles1")]
		ImplementationColorReadType = Gl.IMPLEMENTATION_COLOR_READ_TYPE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_NV_multisample_coverage")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		Samples = Gl.SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_BUFFERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleBuffers = Gl.SAMPLE_BUFFERS,

		/// <summary>
		/// Strongly typed for value GL_STEREO.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Stereo = Gl.STEREO,

	}

	/// <summary>
	/// Strongly typed enumeration GetHistogramParameterPNameEXT.
	/// </summary>
	public enum GetHistogramParameterPNameEXT
	{
		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_ALPHA_SIZE_EXT, GL_HISTOGRAM_ALPHA_SIZE, GL_HISTOGRAM_ALPHA_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramAlphaSize = Gl.HISTOGRAM_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_BLUE_SIZE_EXT, GL_HISTOGRAM_BLUE_SIZE, GL_HISTOGRAM_BLUE_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramBlueSize = Gl.HISTOGRAM_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_FORMAT_EXT, GL_HISTOGRAM_FORMAT, GL_HISTOGRAM_FORMAT_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramFormat = Gl.HISTOGRAM_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_GREEN_SIZE_EXT, GL_HISTOGRAM_GREEN_SIZE, GL_HISTOGRAM_GREEN_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramGreenSize = Gl.HISTOGRAM_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_LUMINANCE_SIZE_EXT, GL_HISTOGRAM_LUMINANCE_SIZE, GL_HISTOGRAM_LUMINANCE_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramLuminanceSize = Gl.HISTOGRAM_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_RED_SIZE_EXT, GL_HISTOGRAM_RED_SIZE, GL_HISTOGRAM_RED_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramRedSize = Gl.HISTOGRAM_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_SINK_EXT, GL_HISTOGRAM_SINK, GL_HISTOGRAM_SINK_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramSink = Gl.HISTOGRAM_SINK,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_WIDTH_EXT, GL_HISTOGRAM_WIDTH, GL_HISTOGRAM_WIDTH_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		HistogramWidth = Gl.HISTOGRAM_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration GetMapQuery.
	/// </summary>
	public enum GetMapQuery
	{
		/// <summary>
		/// Strongly typed for value GL_COEFF.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Coeff = Gl.COEFF,

		/// <summary>
		/// Strongly typed for value GL_DOMAIN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Domain = Gl.DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_ORDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Order = Gl.ORDER,

	}

	/// <summary>
	/// Strongly typed enumeration GetMinmaxParameterPNameEXT.
	/// </summary>
	public enum GetMinmaxParameterPNameEXT
	{
		/// <summary>
		/// Strongly typed for value GL_MINMAX_FORMAT, GL_MINMAX_FORMAT_EXT, GL_MINMAX_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		MinmaxFormat = Gl.MINMAX_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_SINK, GL_MINMAX_SINK_EXT, GL_MINMAX_SINK.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		MinmaxSink = Gl.MINMAX_SINK,

	}

	/// <summary>
	/// Strongly typed enumeration GetPixelMap.
	/// </summary>
	public enum GetPixelMap
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapAToA = Gl.PIXEL_MAP_A_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapBToB = Gl.PIXEL_MAP_B_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapGToG = Gl.PIXEL_MAP_G_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToA = Gl.PIXEL_MAP_I_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToB = Gl.PIXEL_MAP_I_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToG = Gl.PIXEL_MAP_I_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToI = Gl.PIXEL_MAP_I_TO_I,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToR = Gl.PIXEL_MAP_I_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapRToR = Gl.PIXEL_MAP_R_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapSToS = Gl.PIXEL_MAP_S_TO_S,

	}

	/// <summary>
	/// Strongly typed enumeration GetPName.
	/// </summary>
	public enum GetPName
	{
		/// <summary>
		/// Strongly typed for value GL_ACCUM_ALPHA_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumAlphaBits = Gl.ACCUM_ALPHA_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_BLUE_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumBlueBits = Gl.ACCUM_BLUE_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_CLEAR_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumClearValue = Gl.ACCUM_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_GREEN_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumGreenBits = Gl.ACCUM_GREEN_BITS,

		/// <summary>
		/// Strongly typed for value GL_ACCUM_RED_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AccumRedBits = Gl.ACCUM_RED_BITS,

		/// <summary>
		/// Strongly typed for value GL_ALIASED_LINE_WIDTH_RANGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		AliasedLineWidthRange = Gl.ALIASED_LINE_WIDTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_ALIASED_POINT_SIZE_RANGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AliasedPointSizeRange = Gl.ALIASED_POINT_SIZE_RANGE,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaBias = Gl.ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaBits = Gl.ALPHA_BITS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaScale = Gl.ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST, GL_ALPHA_TEST_QCOM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaTest = Gl.ALPHA_TEST,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST_FUNC, GL_ALPHA_TEST_FUNC_QCOM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaTestFunc = Gl.ALPHA_TEST_FUNC,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_TEST_REF, GL_ALPHA_TEST_REF_QCOM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaTestRef = Gl.ALPHA_TEST_REF,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncDrawPixelsSgix = Gl.ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_histogram")]
		AsyncHistogramSgix = Gl.ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_MARKER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async")]
		AsyncMarkerSgix = Gl.ASYNC_MARKER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncReadPixelsSgix = Gl.ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		AsyncTexImageSgix = Gl.ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_ATTRIB_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AttribStackDepth = Gl.ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_AUTO_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AutoNormal = Gl.AUTO_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_AUX_BUFFERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AuxBuffers = Gl.AUX_BUFFERS,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_BLEND_COLOR_EXT.
		/// </summary>
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_color")]
		BlendColor = Gl.BLEND_COLOR,

		/// <summary>
		/// Strongly typed for value GL_BLEND_DST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		BlendDst = Gl.BLEND_DST,

		/// <summary>
		/// Strongly typed for value GL_BLEND_EQUATION_EXT.
		/// </summary>
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_blend_minmax", Api = "gl|gles1|gles2")]
		[RequiredByFeature("GL_OES_blend_subtract", Api = "gles1")]
		BlendEquation = Gl.BLEND_EQUATION,

		/// <summary>
		/// Strongly typed for value GL_BLEND_SRC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		BlendSrc = Gl.BLEND_SRC,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BlueBias = Gl.BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BlueBits = Gl.BLUE_BITS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BlueScale = Gl.BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_CALLIGRAPHIC_FRAGMENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_calligraphic_fragment")]
		CalligraphicFragmentSgix = Gl.CALLIGRAPHIC_FRAGMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_ATTRIB_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClientAttribStackDepth = Gl.CLIENT_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane0 = Gl.CLIP_PLANE0,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane1 = Gl.CLIP_PLANE1,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane2 = Gl.CLIP_PLANE2,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane3 = Gl.CLIP_PLANE3,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane4 = Gl.CLIP_PLANE4,

		/// <summary>
		/// Strongly typed for value GL_CLIP_PLANE5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ClipPlane5 = Gl.CLIP_PLANE5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArray = Gl.COLOR_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		ColorArrayCountExt = Gl.COLOR_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArraySize = Gl.COLOR_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArrayStride = Gl.COLOR_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArrayType = Gl.COLOR_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_CLEAR_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		ColorClearValue = Gl.COLOR_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_LOGIC_OP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		ColorLogicOp = Gl.COLOR_LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorMaterial = Gl.COLOR_MATERIAL,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL_FACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorMaterialFace = Gl.COLOR_MATERIAL_FACE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATERIAL_PARAMETER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorMaterialParameter = Gl.COLOR_MATERIAL_PARAMETER,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATRIX_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		ColorMatrix = Gl.COLOR_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_COLOR_MATRIX_STACK_DEPTH_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		ColorMatrixStackDepth = Gl.COLOR_MATRIX_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		ColorTable = Gl.COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_WRITEMASK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		ColorWritemask = Gl.COLOR_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_1D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution1d = Gl.CONVOLUTION_1D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Convolution2d = Gl.CONVOLUTION_2D,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_convolution_accuracy")]
		ConvolutionHintSgix = Gl.CONVOLUTION_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		CullFace = Gl.CULL_FACE,

		/// <summary>
		/// Strongly typed for value GL_CULL_FACE_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		CullFaceMode = Gl.CULL_FACE_MODE,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentColor = Gl.CURRENT_COLOR,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentIndex = Gl.CURRENT_INDEX,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentNormal = Gl.CURRENT_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterColor = Gl.CURRENT_RASTER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_DISTANCE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterDistance = Gl.CURRENT_RASTER_DISTANCE,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterIndex = Gl.CURRENT_RASTER_INDEX,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_POSITION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterPosition = Gl.CURRENT_RASTER_POSITION,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_POSITION_VALID.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterPositionValid = Gl.CURRENT_RASTER_POSITION_VALID,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_RASTER_TEXTURE_COORDS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentRasterTextureCoords = Gl.CURRENT_RASTER_TEXTURE_COORDS,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_TEXTURE_COORDS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CurrentTextureCoords = Gl.CURRENT_TEXTURE_COORDS,

		/// <summary>
		/// Strongly typed for value GL_DEFORMATIONS_MASK_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_polynomial_ffd")]
		DeformationsMaskSgix = Gl.DEFORMATIONS_MASK_SGIX,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DepthBias = Gl.DEPTH_BIAS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DepthBits = Gl.DEPTH_BITS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_CLEAR_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthClearValue = Gl.DEPTH_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_FUNC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthFunc = Gl.DEPTH_FUNC,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_RANGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		DepthRange = Gl.DEPTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DepthScale = Gl.DEPTH_SCALE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthTest = Gl.DEPTH_TEST,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_WRITEMASK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DepthWritemask = Gl.DEPTH_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_2D_BINDING_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTexture2dBindingSgis = Gl.DETAIL_TEXTURE_2D_BINDING_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DEVICE_LUID_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		DeviceLuidExt = Gl.DEVICE_LUID_EXT,

		/// <summary>
		/// Strongly typed for value GL_DEVICE_NODE_MASK_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object_win32", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		DeviceNodeMaskExt = Gl.DEVICE_NODE_MASK_EXT,

		/// <summary>
		/// Strongly typed for value GL_DEVICE_UUID_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		DeviceUuidExt = Gl.DEVICE_UUID_EXT,

		/// <summary>
		/// Strongly typed for value GL_DISTANCE_ATTENUATION_SGIS.
		/// </summary>
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		DistanceAttenuationExt = Gl.DISTANCE_ATTENUATION_EXT,

		/// <summary>
		/// Strongly typed for value GL_DITHER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Dither = Gl.DITHER,

		/// <summary>
		/// Strongly typed for value GL_DOUBLEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Doublebuffer = Gl.DOUBLEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRAW_BUFFER, GL_DRAW_BUFFER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		DrawBuffer = Gl.DRAW_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_DRIVER_UUID_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		DriverUuidExt = Gl.DRIVER_UUID_EXT,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EdgeFlag = Gl.EDGE_FLAG,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EdgeFlagArray = Gl.EDGE_FLAG_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		EdgeFlagArrayCountExt = Gl.EDGE_FLAG_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EdgeFlagArrayStride = Gl.EDGE_FLAG_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FeedbackBufferSize = Gl.FEEDBACK_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FeedbackBufferType = Gl.FEEDBACK_BUFFER_TYPE,

		/// <summary>
		/// Strongly typed for value GL_FOG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Fog = Gl.FOG,

		/// <summary>
		/// Strongly typed for value GL_FOG_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogColor = Gl.FOG_COLOR,

		/// <summary>
		/// Strongly typed for value GL_FOG_DENSITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogDensity = Gl.FOG_DENSITY,

		/// <summary>
		/// Strongly typed for value GL_FOG_END.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogEnd = Gl.FOG_END,

		/// <summary>
		/// Strongly typed for value GL_FOG_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		FogFuncPointsSgis = Gl.FOG_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_FOG_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogHint = Gl.FOG_HINT,

		/// <summary>
		/// Strongly typed for value GL_FOG_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogIndex = Gl.FOG_INDEX,

		/// <summary>
		/// Strongly typed for value GL_FOG_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogMode = Gl.FOG_MODE,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fog_offset")]
		FogOffsetSgix = Gl.FOG_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_OFFSET_VALUE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fog_offset")]
		FogOffsetValueSgix = Gl.FOG_OFFSET_VALUE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_START.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogStart = Gl.FOG_START,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_FACE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentColorMaterialFaceSgix = Gl.FRAGMENT_COLOR_MATERIAL_FACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentColorMaterialParameterSgix = Gl.FRAGMENT_COLOR_MATERIAL_PARAMETER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_COLOR_MATERIAL_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentColorMaterialSgix = Gl.FRAGMENT_COLOR_MATERIAL_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHTING_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightingSgix = Gl.FRAGMENT_LIGHTING_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelAmbientSgix = Gl.FRAGMENT_LIGHT_MODEL_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelLocalViewerSgix = Gl.FRAGMENT_LIGHT_MODEL_LOCAL_VIEWER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelNormalInterpolationSgix = Gl.FRAGMENT_LIGHT_MODEL_NORMAL_INTERPOLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLightModelTwoSideSgix = Gl.FRAGMENT_LIGHT_MODEL_TWO_SIDE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_FACTOR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		FramezoomFactorSgix = Gl.FRAMEZOOM_FACTOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAMEZOOM_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		FramezoomSgix = Gl.FRAMEZOOM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRONT_FACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontFace = Gl.FRONT_FACE,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_HINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GenerateMipmapHint = Gl.GENERATE_MIPMAP_HINT,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GreenBias = Gl.GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GreenBits = Gl.GREEN_BITS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GreenScale = Gl.GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexArray = Gl.INDEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		IndexArrayCountExt = Gl.INDEX_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexArrayStride = Gl.INDEX_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexArrayType = Gl.INDEX_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexBits = Gl.INDEX_BITS,

		/// <summary>
		/// Strongly typed for value GL_INDEX_CLEAR_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexClearValue = Gl.INDEX_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_LOGIC_OP, GL_LOGIC_OP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LogicOp = Gl.LOGIC_OP,

		/// <summary>
		/// Strongly typed for value GL_INDEX_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexMode = Gl.INDEX_MODE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_OFFSET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexOffset = Gl.INDEX_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_INDEX_SHIFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexShift = Gl.INDEX_SHIFT,

		/// <summary>
		/// Strongly typed for value GL_INDEX_WRITEMASK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexWritemask = Gl.INDEX_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_INSTRUMENT_MEASUREMENTS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		InstrumentMeasurementsSgix = Gl.INSTRUMENT_MEASUREMENTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_INTERLACE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_interlace")]
		InterlaceSgix = Gl.INTERLACE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_IR_INSTRUMENT1_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_ir_instrument1")]
		IrInstrument1Sgix = Gl.IR_INSTRUMENT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light7 = Gl.LIGHT7,

		/// <summary>
		/// Strongly typed for value GL_LIGHTING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Lighting = Gl.LIGHTING,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_ENV_MODE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		LightEnvModeSgix = Gl.LIGHT_ENV_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_AMBIENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelAmbient = Gl.LIGHT_MODEL_AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_COLOR_CONTROL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelColorControl = Gl.LIGHT_MODEL_COLOR_CONTROL,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_LOCAL_VIEWER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelLocalViewer = Gl.LIGHT_MODEL_LOCAL_VIEWER,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_TWO_SIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelTwoSide = Gl.LIGHT_MODEL_TWO_SIDE,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		LineSmooth = Gl.LINE_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		LineSmoothHint = Gl.LINE_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineStipple = Gl.LINE_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE_PATTERN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineStipplePattern = Gl.LINE_STIPPLE_PATTERN,

		/// <summary>
		/// Strongly typed for value GL_LINE_STIPPLE_REPEAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LineStippleRepeat = Gl.LINE_STIPPLE_REPEAT,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		LineWidth = Gl.LINE_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH_GRANULARITY, GL_SMOOTH_LINE_WIDTH_GRANULARITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		LineWidthGranularity = Gl.LINE_WIDTH_GRANULARITY,

		/// <summary>
		/// Strongly typed for value GL_LINE_WIDTH_RANGE, GL_SMOOTH_LINE_WIDTH_RANGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		LineWidthRange = Gl.LINE_WIDTH_RANGE,

		/// <summary>
		/// Strongly typed for value GL_LIST_BASE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ListBase = Gl.LIST_BASE,

		/// <summary>
		/// Strongly typed for value GL_LIST_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ListIndex = Gl.LIST_INDEX,

		/// <summary>
		/// Strongly typed for value GL_LIST_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ListMode = Gl.LIST_MODE,

		/// <summary>
		/// Strongly typed for value GL_LOGIC_OP_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		LogicOpMode = Gl.LOGIC_OP_MODE,

		/// <summary>
		/// Strongly typed for value GL_MAP1_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Color4 = Gl.MAP1_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_GRID_DOMAIN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1GridDomain = Gl.MAP1_GRID_DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_MAP1_GRID_SEGMENTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1GridSegments = Gl.MAP1_GRID_SEGMENTS,

		/// <summary>
		/// Strongly typed for value GL_MAP1_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Index = Gl.MAP1_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP1_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Normal = Gl.MAP1_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord1 = Gl.MAP1_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord2 = Gl.MAP1_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord3 = Gl.MAP1_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1TextureCoord4 = Gl.MAP1_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex3 = Gl.MAP1_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP1_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map1Vertex4 = Gl.MAP1_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_COLOR_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Color4 = Gl.MAP2_COLOR_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_GRID_DOMAIN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2GridDomain = Gl.MAP2_GRID_DOMAIN,

		/// <summary>
		/// Strongly typed for value GL_MAP2_GRID_SEGMENTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2GridSegments = Gl.MAP2_GRID_SEGMENTS,

		/// <summary>
		/// Strongly typed for value GL_MAP2_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Index = Gl.MAP2_INDEX,

		/// <summary>
		/// Strongly typed for value GL_MAP2_NORMAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Normal = Gl.MAP2_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord1 = Gl.MAP2_TEXTURE_COORD_1,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord2 = Gl.MAP2_TEXTURE_COORD_2,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord3 = Gl.MAP2_TEXTURE_COORD_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_TEXTURE_COORD_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2TextureCoord4 = Gl.MAP2_TEXTURE_COORD_4,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex3 = Gl.MAP2_VERTEX_3,

		/// <summary>
		/// Strongly typed for value GL_MAP2_VERTEX_4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Map2Vertex4 = Gl.MAP2_VERTEX_4,

		/// <summary>
		/// Strongly typed for value GL_MAP_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MapColor = Gl.MAP_COLOR,

		/// <summary>
		/// Strongly typed for value GL_MAP_STENCIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MapStencil = Gl.MAP_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_MATRIX_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MatrixMode = Gl.MATRIX_MODE,

		/// <summary>
		/// Strongly typed for value GL_MAX_3D_TEXTURE_SIZE_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		Max3dTextureSize = Gl.MAX_3D_TEXTURE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_MAX_4D_TEXTURE_SIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Max4dTextureSizeSgis = Gl.MAX_4D_TEXTURE_SIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_MAX_ACTIVE_LIGHTS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		MaxActiveLightsSgix = Gl.MAX_ACTIVE_LIGHTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_DRAW_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		MaxAsyncDrawPixelsSgix = Gl.MAX_ASYNC_DRAW_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_HISTOGRAM_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_histogram")]
		MaxAsyncHistogramSgix = Gl.MAX_ASYNC_HISTOGRAM_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_READ_PIXELS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		MaxAsyncReadPixelsSgix = Gl.MAX_ASYNC_READ_PIXELS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ASYNC_TEX_IMAGE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_async_pixel")]
		MaxAsyncTexImageSgix = Gl.MAX_ASYNC_TEX_IMAGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_ATTRIB_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxAttribStackDepth = Gl.MAX_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIENT_ATTRIB_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxClientAttribStackDepth = Gl.MAX_CLIENT_ATTRIB_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		MaxClipmapDepthSgix = Gl.MAX_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		MaxClipmapVirtualDepthSgix = Gl.MAX_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_CLIP_DISTANCES, GL_MAX_CLIP_PLANES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxClipPlanes = Gl.MAX_CLIP_PLANES,

		/// <summary>
		/// Strongly typed for value GL_MAX_COLOR_MATRIX_STACK_DEPTH_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		MaxColorMatrixStackDepth = Gl.MAX_COLOR_MATRIX_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_EVAL_ORDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxEvalOrder = Gl.MAX_EVAL_ORDER,

		/// <summary>
		/// Strongly typed for value GL_MAX_FOG_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_fog_function")]
		MaxFogFuncPointsSgis = Gl.MAX_FOG_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_MAX_FRAGMENT_LIGHTS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		MaxFragmentLightsSgix = Gl.MAX_FRAGMENT_LIGHTS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_FRAMEZOOM_FACTOR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_framezoom")]
		MaxFramezoomFactorSgix = Gl.MAX_FRAMEZOOM_FACTOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_MAX_LIGHTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxLights = Gl.MAX_LIGHTS,

		/// <summary>
		/// Strongly typed for value GL_MAX_LIST_NESTING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxListNesting = Gl.MAX_LIST_NESTING,

		/// <summary>
		/// Strongly typed for value GL_MAX_MODELVIEW_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxModelviewStackDepth = Gl.MAX_MODELVIEW_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_NAME_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxNameStackDepth = Gl.MAX_NAME_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_PIXEL_MAP_TABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxPixelMapTable = Gl.MAX_PIXEL_MAP_TABLE,

		/// <summary>
		/// Strongly typed for value GL_MAX_PROJECTION_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxProjectionStackDepth = Gl.MAX_PROJECTION_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_TEXTURE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		MaxTextureSize = Gl.MAX_TEXTURE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_MAX_TEXTURE_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MaxTextureStackDepth = Gl.MAX_TEXTURE_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_VIEWPORT_DIMS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		MaxViewportDims = Gl.MAX_VIEWPORT_DIMS,

		/// <summary>
		/// Strongly typed for value GL_MINMAX_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Minmax = Gl.MINMAX,

		/// <summary>
		/// Strongly typed for value GL_MODELVIEW0_MATRIX_EXT, GL_MODELVIEW_MATRIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ModelviewMatrix = Gl.MODELVIEW_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_MODELVIEW0_STACK_DEPTH_EXT, GL_MODELVIEW_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ModelviewStackDepth = Gl.MODELVIEW_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		Multisample = Gl.MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_NAME_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NameStackDepth = Gl.NAME_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_NORMALIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Normalize = Gl.NORMALIZE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NormalArray = Gl.NORMAL_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		NormalArrayCountExt = Gl.NORMAL_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NormalArrayStride = Gl.NORMAL_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NormalArrayType = Gl.NORMAL_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_PACK_ALIGNMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		PackAlignment = Gl.PACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_PACK_CMYK_HINT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		PackCmykHintExt = Gl.PACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		PackImageDepthSgis = Gl.PACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		PackImageHeight = Gl.PACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_PACK_LSB_FIRST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PackLsbFirst = Gl.PACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		PackResampleSgix = Gl.PACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_ROW_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackRowLength = Gl.PACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_IMAGES_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		PackSkipImages = Gl.PACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_PIXELS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackSkipPixels = Gl.PACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_ROWS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackSkipRows = Gl.PACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		PackSkipVolumesSgis = Gl.PACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		PackSubsampleRateSgix = Gl.PACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_SWAP_BYTES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PackSwapBytes = Gl.PACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_PERSPECTIVE_CORRECTION_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PerspectiveCorrectionHint = Gl.PERSPECTIVE_CORRECTION_HINT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapAToASize = Gl.PIXEL_MAP_A_TO_A_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapBToBSize = Gl.PIXEL_MAP_B_TO_B_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapGToGSize = Gl.PIXEL_MAP_G_TO_G_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToASize = Gl.PIXEL_MAP_I_TO_A_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToBSize = Gl.PIXEL_MAP_I_TO_B_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToGSize = Gl.PIXEL_MAP_I_TO_G_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToISize = Gl.PIXEL_MAP_I_TO_I_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToRSize = Gl.PIXEL_MAP_I_TO_R_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapRToRSize = Gl.PIXEL_MAP_R_TO_R_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapSToSSize = Gl.PIXEL_MAP_S_TO_S_SIZE,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEXTURE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		PixelTextureSgis = Gl.PIXEL_TEXTURE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_MODE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		PixelTexGenModeSgix = Gl.PIXEL_TEX_GEN_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TEX_GEN_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_texture")]
		PixelTexGenSgix = Gl.PIXEL_TEX_GEN_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_BEST_ALIGNMENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileBestAlignmentSgix = Gl.PIXEL_TILE_BEST_ALIGNMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_INCREMENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileCacheIncrementSgix = Gl.PIXEL_TILE_CACHE_INCREMENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_SIZE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileCacheSizeSgix = Gl.PIXEL_TILE_CACHE_SIZE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridDepthSgix = Gl.PIXEL_TILE_GRID_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_HEIGHT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridHeightSgix = Gl.PIXEL_TILE_GRID_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_WIDTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridWidthSgix = Gl.PIXEL_TILE_GRID_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_HEIGHT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileHeightSgix = Gl.PIXEL_TILE_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_WIDTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileWidthSgix = Gl.PIXEL_TILE_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POINT_FADE_THRESHOLD_SIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		PointFadeThresholdSize = Gl.POINT_FADE_THRESHOLD_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		PointSize = Gl.POINT_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_GRANULARITY, GL_SMOOTH_POINT_SIZE_GRANULARITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PointSizeGranularity = Gl.POINT_SIZE_GRANULARITY,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MAX_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSizeMax = Gl.POINT_SIZE_MAX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MIN_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSizeMin = Gl.POINT_SIZE_MIN,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_RANGE, GL_SMOOTH_POINT_SIZE_RANGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PointSizeRange = Gl.POINT_SIZE_RANGE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSmooth = Gl.POINT_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSmoothHint = Gl.POINT_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		PolygonMode = Gl.POLYGON_MODE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_polygon_offset")]
		PolygonOffsetBiasExt = Gl.POLYGON_OFFSET_BIAS_EXT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FACTOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_polygon_offset")]
		PolygonOffsetFactor = Gl.POLYGON_OFFSET_FACTOR,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_FILL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		PolygonOffsetFill = Gl.POLYGON_OFFSET_FILL,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_LINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		PolygonOffsetLine = Gl.POLYGON_OFFSET_LINE,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_POINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		PolygonOffsetPoint = Gl.POLYGON_OFFSET_POINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_OFFSET_UNITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		PolygonOffsetUnits = Gl.POLYGON_OFFSET_UNITS,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PolygonSmooth = Gl.POLYGON_SMOOTH,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PolygonSmoothHint = Gl.POLYGON_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_STIPPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PolygonStipple = Gl.POLYGON_STIPPLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixAlphaBias = Gl.POST_COLOR_MATRIX_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixAlphaScale = Gl.POST_COLOR_MATRIX_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixBlueBias = Gl.POST_COLOR_MATRIX_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixBlueScale = Gl.POST_COLOR_MATRIX_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostColorMatrixColorTable = Gl.POST_COLOR_MATRIX_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixGreenBias = Gl.POST_COLOR_MATRIX_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixGreenScale = Gl.POST_COLOR_MATRIX_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixRedBias = Gl.POST_COLOR_MATRIX_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixRedScale = Gl.POST_COLOR_MATRIX_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionAlphaBias = Gl.POST_CONVOLUTION_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionAlphaScale = Gl.POST_CONVOLUTION_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionBlueBias = Gl.POST_CONVOLUTION_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionBlueScale = Gl.POST_CONVOLUTION_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_table")]
		PostConvolutionColorTable = Gl.POST_CONVOLUTION_COLOR_TABLE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionGreenBias = Gl.POST_CONVOLUTION_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionGreenScale = Gl.POST_CONVOLUTION_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionRedBias = Gl.POST_CONVOLUTION_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionRedScale = Gl.POST_CONVOLUTION_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_RANGE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterBiasRangeSgix = Gl.POST_TEXTURE_FILTER_BIAS_RANGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_RANGE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterScaleRangeSgix = Gl.POST_TEXTURE_FILTER_SCALE_RANGE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION_MATRIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ProjectionMatrix = Gl.PROJECTION_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ProjectionStackDepth = Gl.PROJECTION_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_READ_BUFFER, GL_READ_BUFFER_EXT, GL_READ_BUFFER_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_read_buffer", Api = "gles2")]
		ReadBuffer = Gl.READ_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_RED_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RedBias = Gl.RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_RED_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RedBits = Gl.RED_BITS,

		/// <summary>
		/// Strongly typed for value GL_RED_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RedScale = Gl.RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_EQUATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_reference_plane")]
		ReferencePlaneEquationSgix = Gl.REFERENCE_PLANE_EQUATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_REFERENCE_PLANE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_reference_plane")]
		ReferencePlaneSgix = Gl.REFERENCE_PLANE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RENDER_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RenderMode = Gl.RENDER_MODE,

		/// <summary>
		/// Strongly typed for value GL_RESCALE_NORMAL_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_rescale_normal")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RescaleNormal = Gl.RESCALE_NORMAL,

		/// <summary>
		/// Strongly typed for value GL_RGBA_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RgbaMode = Gl.RGBA_MODE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLES_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_NV_multisample_coverage")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		Samples = Gl.SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_MASK_SGIS.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleAlphaToMaskExt = Gl.SAMPLE_ALPHA_TO_MASK_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_ALPHA_TO_ONE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_compatibility", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleAlphaToOne = Gl.SAMPLE_ALPHA_TO_ONE,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_BUFFERS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleBuffers = Gl.SAMPLE_BUFFERS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_INVERT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleMaskInvertExt = Gl.SAMPLE_MASK_INVERT_EXT,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleMaskSgis = Gl.SAMPLE_MASK_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_MASK_VALUE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_multisample")]
		SampleMaskValueSgis = Gl.SAMPLE_MASK_VALUE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLE_PATTERN_SGIS.
		/// </summary>
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		SamplePatternExt = Gl.SAMPLE_PATTERN_EXT,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_BOX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		ScissorBox = Gl.SCISSOR_BOX,

		/// <summary>
		/// Strongly typed for value GL_SCISSOR_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		ScissorTest = Gl.SCISSOR_TEST,

		/// <summary>
		/// Strongly typed for value GL_SELECTION_BUFFER_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SelectionBufferSize = Gl.SELECTION_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Separable2d = Gl.SEPARABLE_2D,

		/// <summary>
		/// Strongly typed for value GL_SHADE_MODEL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ShadeModel = Gl.SHADE_MODEL,

		/// <summary>
		/// Strongly typed for value GL_SHARED_TEXTURE_PALETTE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_shared_texture_palette")]
		SharedTexturePaletteExt = Gl.SHARED_TEXTURE_PALETTE_EXT,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_AXIS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		SpriteAxisSgix = Gl.SPRITE_AXIS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_MODE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		SpriteModeSgix = Gl.SPRITE_MODE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		SpriteSgix = Gl.SPRITE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SPRITE_TRANSLATION_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_sprite")]
		SpriteTranslationSgix = Gl.SPRITE_TRANSLATION_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		StencilBits = Gl.STENCIL_BITS,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_CLEAR_VALUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilClearValue = Gl.STENCIL_CLEAR_VALUE,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_FAIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilFail = Gl.STENCIL_FAIL,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_FUNC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilFunc = Gl.STENCIL_FUNC,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_PASS_DEPTH_FAIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilPassDepthFail = Gl.STENCIL_PASS_DEPTH_FAIL,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_PASS_DEPTH_PASS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilPassDepthPass = Gl.STENCIL_PASS_DEPTH_PASS,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_REF.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilRef = Gl.STENCIL_REF,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilTest = Gl.STENCIL_TEST,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_VALUE_MASK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilValueMask = Gl.STENCIL_VALUE_MASK,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_WRITEMASK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		StencilWritemask = Gl.STENCIL_WRITEMASK,

		/// <summary>
		/// Strongly typed for value GL_STEREO.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Stereo = Gl.STEREO,

		/// <summary>
		/// Strongly typed for value GL_SUBPIXEL_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		SubpixelBits = Gl.SUBPIXEL_BITS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_BINDING_EXT, GL_TEXTURE_BINDING_3D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		TextureBinding3d = Gl.TEXTURE_BINDING_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_BINDING_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dBindingSgis = Gl.TEXTURE_4D_BINDING_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BINDING_1D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		TextureBinding1d = Gl.TEXTURE_BINDING_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BINDING_2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		TextureBinding2d = Gl.TEXTURE_BINDING_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COLOR_TABLE_SGI.
		/// </summary>
		[RequiredByFeature("GL_SGI_texture_color_table")]
		TextureColorTableSgi = Gl.TEXTURE_COLOR_TABLE_SGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArray = Gl.TEXTURE_COORD_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		TextureCoordArrayCountExt = Gl.TEXTURE_COORD_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArraySize = Gl.TEXTURE_COORD_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArrayStride = Gl.TEXTURE_COORD_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArrayType = Gl.TEXTURE_COORD_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_Q.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenQ = Gl.TEXTURE_GEN_Q,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenR = Gl.TEXTURE_GEN_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenS = Gl.TEXTURE_GEN_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenT = Gl.TEXTURE_GEN_T,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MATRIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureMatrix = Gl.TEXTURE_MATRIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_STACK_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureStackDepth = Gl.TEXTURE_STACK_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ALIGNMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnpackAlignment = Gl.UNPACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_CMYK_HINT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		UnpackCmykHintExt = Gl.UNPACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		UnpackImageDepthSgis = Gl.UNPACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		UnpackImageHeight = Gl.UNPACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_LSB_FIRST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		UnpackLsbFirst = Gl.UNPACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		UnpackResampleSgix = Gl.UNPACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ROW_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackRowLength = Gl.UNPACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_IMAGES_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		UnpackSkipImages = Gl.UNPACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_PIXELS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackSkipPixels = Gl.UNPACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_ROWS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackSkipRows = Gl.UNPACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		UnpackSkipVolumesSgis = Gl.UNPACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		UnpackSubsampleRateSgix = Gl.UNPACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SWAP_BYTES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		UnpackSwapBytes = Gl.UNPACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArray = Gl.VERTEX_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_COUNT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_vertex_array")]
		VertexArrayCountExt = Gl.VERTEX_ARRAY_COUNT_EXT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArraySize = Gl.VERTEX_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArrayStride = Gl.VERTEX_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArrayType = Gl.VERTEX_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_vertex_preclip")]
		VertexPreclipHintSgix = Gl.VERTEX_PRECLIP_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_vertex_preclip")]
		VertexPreclipSgix = Gl.VERTEX_PRECLIP_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VIEWPORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		Viewport = Gl.VIEWPORT,

		/// <summary>
		/// Strongly typed for value GL_ZOOM_X.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ZoomX = Gl.ZOOM_X,

		/// <summary>
		/// Strongly typed for value GL_ZOOM_Y.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ZoomY = Gl.ZOOM_Y,

		/// <summary>
		/// Strongly typed for value GL_NUM_EXTENSIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		NumExtensions = Gl.NUM_EXTENSIONS,

		/// <summary>
		/// Strongly typed for value GL_NUM_SHADING_LANGUAGE_VERSIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		NumShadingLanguageVersions = Gl.NUM_SHADING_LANGUAGE_VERSIONS,

	}

	/// <summary>
	/// Strongly typed enumeration GetPointervPName.
	/// </summary>
	public enum GetPointervPName
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR_ARRAY_POINTER, GL_COLOR_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorArrayPointer = Gl.COLOR_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_EDGE_FLAG_ARRAY_POINTER, GL_EDGE_FLAG_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EdgeFlagArrayPointer = Gl.EDGE_FLAG_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_FEEDBACK_BUFFER_POINTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FeedbackBufferPointer = Gl.FEEDBACK_BUFFER_POINTER,

		/// <summary>
		/// Strongly typed for value GL_INDEX_ARRAY_POINTER, GL_INDEX_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexArrayPointer = Gl.INDEX_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_INSTRUMENT_BUFFER_POINTER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_instruments")]
		InstrumentBufferPointerSgix = Gl.INSTRUMENT_BUFFER_POINTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NORMAL_ARRAY_POINTER, GL_NORMAL_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		NormalArrayPointer = Gl.NORMAL_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_SELECTION_BUFFER_POINTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SelectionBufferPointer = Gl.SELECTION_BUFFER_POINTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COORD_ARRAY_POINTER, GL_TEXTURE_COORD_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureCoordArrayPointer = Gl.TEXTURE_COORD_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_POINTER, GL_VERTEX_ARRAY_POINTER_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArrayPointer = Gl.VERTEX_ARRAY_POINTER,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_CALLBACK_FUNCTION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugCallbackFunction = Gl.DEBUG_CALLBACK_FUNCTION,

		/// <summary>
		/// Strongly typed for value GL_DEBUG_CALLBACK_USER_PARAM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_debug_output", Api = "gl|glcore")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		DebugCallbackUserParam = Gl.DEBUG_CALLBACK_USER_PARAM,

	}

	/// <summary>
	/// Strongly typed enumeration GetTextureParameter.
	/// </summary>
	public enum GetTextureParameter
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureFuncPointsSgis = Gl.DETAIL_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureLevelSgis = Gl.DETAIL_TEXTURE_LEVEL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_MODE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureModeSgis = Gl.DETAIL_TEXTURE_MODE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_TEXTURE_SELECT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualTextureSelectSgis = Gl.DUAL_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GenerateMipmap = Gl.GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterBiasSgix = Gl.POST_TEXTURE_FILTER_BIAS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterScaleSgix = Gl.POST_TEXTURE_FILTER_SCALE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_QUAD_TEXTURE_SELECT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadTextureSelectSgis = Gl.QUAD_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SHADOW_AMBIENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow_ambient")]
		ShadowAmbientSgix = Gl.SHADOW_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		SharpenTextureFuncPointsSgis = Gl.SHARPEN_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4DSIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dsizeSgis = Gl.TEXTURE_4DSIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureAlphaSize = Gl.TEXTURE_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BASE_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureBaseLevel = Gl.TEXTURE_BASE_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureBlueSize = Gl.TEXTURE_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureBorder = Gl.TEXTURE_BORDER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_BORDER_COLOR_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		TextureBorderColor = Gl.TEXTURE_BORDER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_CENTER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapCenterSgix = Gl.TEXTURE_CLIPMAP_CENTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapDepthSgix = Gl.TEXTURE_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_FRAME_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapFrameSgix = Gl.TEXTURE_CLIPMAP_FRAME_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapLodOffsetSgix = Gl.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapOffsetSgix = Gl.TEXTURE_CLIPMAP_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapVirtualDepthSgix = Gl.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_OPERATOR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureCompareOperatorSgix = Gl.TEXTURE_COMPARE_OPERATOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureCompareSgix = Gl.TEXTURE_COMPARE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPONENTS, GL_TEXTURE_INTERNAL_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureComponents = Gl.TEXTURE_COMPONENTS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEPTH_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		TextureDepth = Gl.TEXTURE_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_FILTER4_SIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		TextureFilter4SizeSgis = Gl.TEXTURE_FILTER4_SIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEQUAL_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureGequalRSgix = Gl.TEXTURE_GEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureGreenSize = Gl.TEXTURE_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		TextureHeight = Gl.TEXTURE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_INTENSITY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureIntensitySize = Gl.TEXTURE_INTENSITY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LEQUAL_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureLequalRSgix = Gl.TEXTURE_LEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasRSgix = Gl.TEXTURE_LOD_BIAS_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_S_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasSSgix = Gl.TEXTURE_LOD_BIAS_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_T_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasTSgix = Gl.TEXTURE_LOD_BIAS_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LUMINANCE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureLuminanceSize = Gl.TEXTURE_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAG_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMagFilter = Gl.TEXTURE_MAG_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampRSgix = Gl.TEXTURE_MAX_CLAMP_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_S_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampSSgix = Gl.TEXTURE_MAX_CLAMP_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_T_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampTSgix = Gl.TEXTURE_MAX_CLAMP_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_max_level", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMaxLevel = Gl.TEXTURE_MAX_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LOD_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMaxLod = Gl.TEXTURE_MAX_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMinFilter = Gl.TEXTURE_MIN_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_LOD_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMinLod = Gl.TEXTURE_MIN_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_PRIORITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TexturePriority = Gl.TEXTURE_PRIORITY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureRedSize = Gl.TEXTURE_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RESIDENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureResident = Gl.TEXTURE_RESIDENT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		TextureWidth = Gl.TEXTURE_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_Q_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		TextureWrapQSgis = Gl.TEXTURE_WRAP_Q_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_R_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		TextureWrapR = Gl.TEXTURE_WRAP_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapS = Gl.TEXTURE_WRAP_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapT = Gl.TEXTURE_WRAP_T,

	}

	/// <summary>
	/// Strongly typed enumeration GraphicsResetStatus.
	/// </summary>
	public enum GraphicsResetStatus
	{
		/// <summary>
		/// Strongly typed for value GL_NO_ERROR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		NoError = Gl.NO_ERROR,

		/// <summary>
		/// Strongly typed for value GL_GUILTY_CONTEXT_RESET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		GuiltyContextReset = Gl.GUILTY_CONTEXT_RESET,

		/// <summary>
		/// Strongly typed for value GL_INNOCENT_CONTEXT_RESET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		InnocentContextReset = Gl.INNOCENT_CONTEXT_RESET,

		/// <summary>
		/// Strongly typed for value GL_UNKNOWN_CONTEXT_RESET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		UnknownContextReset = Gl.UNKNOWN_CONTEXT_RESET,

	}

	/// <summary>
	/// Strongly typed enumeration HintMode.
	/// </summary>
	public enum HintMode
	{
		/// <summary>
		/// Strongly typed for value GL_DONT_CARE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		DontCare = Gl.DONT_CARE,

		/// <summary>
		/// Strongly typed for value GL_FASTEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Fastest = Gl.FASTEST,

		/// <summary>
		/// Strongly typed for value GL_NICEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Nicest = Gl.NICEST,

	}

	/// <summary>
	/// Strongly typed enumeration HintTarget.
	/// </summary>
	public enum HintTarget
	{
		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_FRG_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AllowDrawFrgHintPgi = Gl.ALLOW_DRAW_FRG_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_MEM_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AllowDrawMemHintPgi = Gl.ALLOW_DRAW_MEM_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_OBJ_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AllowDrawObjHintPgi = Gl.ALLOW_DRAW_OBJ_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALLOW_DRAW_WIN_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AllowDrawWinHintPgi = Gl.ALLOW_DRAW_WIN_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALWAYS_FAST_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AlwaysFastHintPgi = Gl.ALWAYS_FAST_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_ALWAYS_SOFT_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		AlwaysSoftHintPgi = Gl.ALWAYS_SOFT_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_BACK_NORMALS_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		BackNormalsHintPgi = Gl.BACK_NORMALS_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_BINNING_CONTROL_HINT_QCOM.
		/// </summary>
		[RequiredByFeature("GL_QCOM_binning_control", Api = "gles2")]
		BinningControlHintQcom = Gl.BINNING_CONTROL_HINT_QCOM,

		/// <summary>
		/// Strongly typed for value GL_CLIP_FAR_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		ClipFarHintPgi = Gl.CLIP_FAR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CLIP_NEAR_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		ClipNearHintPgi = Gl.CLIP_NEAR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CLIP_VOLUME_CLIPPING_HINT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_clip_volume_hint")]
		ClipVolumeClippingHintExt = Gl.CLIP_VOLUME_CLIPPING_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_CONSERVE_MEMORY_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		ConserveMemoryHintPgi = Gl.CONSERVE_MEMORY_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_CONVOLUTION_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_convolution_accuracy")]
		ConvolutionHintSgix = Gl.CONVOLUTION_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FOG_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		FogHint = Gl.FOG_HINT,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER_DERIVATIVE_HINT, GL_FRAGMENT_SHADER_DERIVATIVE_HINT_ARB, 
		/// GL_FRAGMENT_SHADER_DERIVATIVE_HINT_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		[RequiredByFeature("GL_OES_standard_derivatives", Api = "gles2|glsc2")]
		FragmentShaderDerivativeHint = Gl.FRAGMENT_SHADER_DERIVATIVE_HINT,

		/// <summary>
		/// Strongly typed for value GL_FULL_STIPPLE_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		FullStippleHintPgi = Gl.FULL_STIPPLE_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP_HINT, GL_GENERATE_MIPMAP_HINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GenerateMipmapHint = Gl.GENERATE_MIPMAP_HINT,

		/// <summary>
		/// Strongly typed for value GL_LINE_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		LineSmoothHint = Gl.LINE_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_MATERIAL_SIDE_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		MaterialSideHintPgi = Gl.MATERIAL_SIDE_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_MAX_VERTEX_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		MaxVertexHintPgi = Gl.MAX_VERTEX_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_MULTISAMPLE_FILTER_HINT_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_multisample_filter_hint")]
		MultisampleFilterHintNv = Gl.MULTISAMPLE_FILTER_HINT_NV,

		/// <summary>
		/// Strongly typed for value GL_NATIVE_GRAPHICS_BEGIN_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		NativeGraphicsBeginHintPgi = Gl.NATIVE_GRAPHICS_BEGIN_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_NATIVE_GRAPHICS_END_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		NativeGraphicsEndHintPgi = Gl.NATIVE_GRAPHICS_END_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_PACK_CMYK_HINT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		PackCmykHintExt = Gl.PACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_PERSPECTIVE_CORRECTION_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PerspectiveCorrectionHint = Gl.PERSPECTIVE_CORRECTION_HINT,

		/// <summary>
		/// Strongly typed for value GL_PHONG_HINT_WIN.
		/// </summary>
		[RequiredByFeature("GL_WIN_phong_shading")]
		PhongHintWin = Gl.PHONG_HINT_WIN,

		/// <summary>
		/// Strongly typed for value GL_POINT_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSmoothHint = Gl.POINT_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_POLYGON_SMOOTH_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PolygonSmoothHint = Gl.POLYGON_SMOOTH_HINT,

		/// <summary>
		/// Strongly typed for value GL_PREFER_DOUBLEBUFFER_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		PreferDoublebufferHintPgi = Gl.PREFER_DOUBLEBUFFER_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_BINARY_RETRIEVABLE_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		ProgramBinaryRetrievableHint = Gl.PROGRAM_BINARY_RETRIEVABLE_HINT,

		/// <summary>
		/// Strongly typed for value GL_RECLAIM_MEMORY_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		ReclaimMemoryHintPgi = Gl.RECLAIM_MEMORY_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_SCALEBIAS_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_scalebias_hint")]
		ScalebiasHintSgix = Gl.SCALEBIAS_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_STRICT_DEPTHFUNC_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		StrictDepthfuncHintPgi = Gl.STRICT_DEPTHFUNC_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_STRICT_LIGHTING_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		StrictLightingHintPgi = Gl.STRICT_LIGHTING_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_STRICT_SCISSOR_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		StrictScissorHintPgi = Gl.STRICT_SCISSOR_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSION_HINT, GL_TEXTURE_COMPRESSION_HINT_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		TextureCompressionHint = Gl.TEXTURE_COMPRESSION_HINT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MULTI_BUFFER_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_multi_buffer")]
		TextureMultiBufferHintSgix = Gl.TEXTURE_MULTI_BUFFER_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_STORAGE_HINT_APPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_texture_range")]
		TextureStorageHintApple = Gl.TEXTURE_STORAGE_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_HINT_APPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_transform_hint")]
		TransformHintApple = Gl.TRANSFORM_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_CMYK_HINT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		UnpackCmykHintExt = Gl.UNPACK_CMYK_HINT_EXT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY_STORAGE_HINT_APPLE.
		/// </summary>
		[RequiredByFeature("GL_APPLE_vertex_array_range")]
		VertexArrayStorageHintApple = Gl.VERTEX_ARRAY_STORAGE_HINT_APPLE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_CONSISTENT_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		VertexConsistentHintPgi = Gl.VERTEX_CONSISTENT_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_DATA_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_vertex_hints")]
		VertexDataHintPgi = Gl.VERTEX_DATA_HINT_PGI,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_HINT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_vertex_preclip")]
		VertexPreclipHintSgix = Gl.VERTEX_PRECLIP_HINT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_PRECLIP_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_vertex_preclip")]
		VertexPreclipSgix = Gl.VERTEX_PRECLIP_SGIX,

		/// <summary>
		/// Strongly typed for value GL_WIDE_LINE_HINT_PGI.
		/// </summary>
		[RequiredByFeature("GL_PGI_misc_hints")]
		WideLineHintPgi = Gl.WIDE_LINE_HINT_PGI,

	}

	/// <summary>
	/// Strongly typed enumeration HistogramTargetEXT.
	/// </summary>
	public enum HistogramTargetEXT
	{
		/// <summary>
		/// Strongly typed for value GL_HISTOGRAM, GL_HISTOGRAM_EXT, GL_HISTOGRAM.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Histogram = Gl.HISTOGRAM,

		/// <summary>
		/// Strongly typed for value GL_PROXY_HISTOGRAM, GL_PROXY_HISTOGRAM_EXT, GL_PROXY_HISTOGRAM.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		ProxyHistogram = Gl.PROXY_HISTOGRAM,

	}

	/// <summary>
	/// Strongly typed enumeration IndexPointerType.
	/// </summary>
	public enum IndexPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration InterleavedArrayFormat.
	/// </summary>
	public enum InterleavedArrayFormat
	{
		/// <summary>
		/// Strongly typed for value GL_C3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		C3fV3f = Gl.C3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_C4F_N3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		C4fN3fV3f = Gl.C4F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_C4UB_V2F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		C4ubV2f = Gl.C4UB_V2F,

		/// <summary>
		/// Strongly typed for value GL_C4UB_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		C4ubV3f = Gl.C4UB_V3F,

		/// <summary>
		/// Strongly typed for value GL_N3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		N3fV3f = Gl.N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T2fC3fV3f = Gl.T2F_C3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C4F_N3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T2fC4fN3fV3f = Gl.T2F_C4F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_C4UB_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T2fC4ubV3f = Gl.T2F_C4UB_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_N3F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T2fN3fV3f = Gl.T2F_N3F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T2F_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T2fV3f = Gl.T2F_V3F,

		/// <summary>
		/// Strongly typed for value GL_T4F_C4F_N3F_V4F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T4fC4fN3fV4f = Gl.T4F_C4F_N3F_V4F,

		/// <summary>
		/// Strongly typed for value GL_T4F_V4F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T4fV4f = Gl.T4F_V4F,

		/// <summary>
		/// Strongly typed for value GL_V2F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		V2f = Gl.V2F,

		/// <summary>
		/// Strongly typed for value GL_V3F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		V3f = Gl.V3F,

	}

	/// <summary>
	/// Strongly typed enumeration InternalFormat.
	/// </summary>
	public enum InternalFormat
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Alpha12 = Gl.ALPHA12,

		/// <summary>
		/// Strongly typed for value GL_ALPHA16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Alpha16 = Gl.ALPHA16,

		/// <summary>
		/// Strongly typed for value GL_ALPHA4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Alpha4 = Gl.ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_ALPHA8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Alpha8 = Gl.ALPHA8,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA12_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualAlpha12Sgis = Gl.DUAL_ALPHA12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA16_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualAlpha16Sgis = Gl.DUAL_ALPHA16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualAlpha4Sgis = Gl.DUAL_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_ALPHA8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualAlpha8Sgis = Gl.DUAL_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY12_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualIntensity12Sgis = Gl.DUAL_INTENSITY12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY16_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualIntensity16Sgis = Gl.DUAL_INTENSITY16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualIntensity4Sgis = Gl.DUAL_INTENSITY4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_INTENSITY8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualIntensity8Sgis = Gl.DUAL_INTENSITY8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE12_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminance12Sgis = Gl.DUAL_LUMINANCE12_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE16_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminance16Sgis = Gl.DUAL_LUMINANCE16_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminance4Sgis = Gl.DUAL_LUMINANCE4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminance8Sgis = Gl.DUAL_LUMINANCE8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE_ALPHA4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminanceAlpha4Sgis = Gl.DUAL_LUMINANCE_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_LUMINANCE_ALPHA8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualLuminanceAlpha8Sgis = Gl.DUAL_LUMINANCE_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Intensity = Gl.INTENSITY,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Intensity12 = Gl.INTENSITY12,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Intensity16 = Gl.INTENSITY16,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Intensity4 = Gl.INTENSITY4,

		/// <summary>
		/// Strongly typed for value GL_INTENSITY8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Intensity8 = Gl.INTENSITY8,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance12 = Gl.LUMINANCE12,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12_ALPHA12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance12Alpha12 = Gl.LUMINANCE12_ALPHA12,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE12_ALPHA4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance12Alpha4 = Gl.LUMINANCE12_ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance16 = Gl.LUMINANCE16,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE16_ALPHA16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance16Alpha16 = Gl.LUMINANCE16_ALPHA16,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance4 = Gl.LUMINANCE4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE4_ALPHA4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance4Alpha4 = Gl.LUMINANCE4_ALPHA4,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE6_ALPHA2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance6Alpha2 = Gl.LUMINANCE6_ALPHA2,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance8 = Gl.LUMINANCE8,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE8_ALPHA8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance8Alpha8 = Gl.LUMINANCE8_ALPHA8,

		/// <summary>
		/// Strongly typed for value GL_QUAD_ALPHA4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadAlpha4Sgis = Gl.QUAD_ALPHA4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_ALPHA8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadAlpha8Sgis = Gl.QUAD_ALPHA8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_INTENSITY4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadIntensity4Sgis = Gl.QUAD_INTENSITY4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_INTENSITY8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadIntensity8Sgis = Gl.QUAD_INTENSITY8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_LUMINANCE4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadLuminance4Sgis = Gl.QUAD_LUMINANCE4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_LUMINANCE8_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadLuminance8Sgis = Gl.QUAD_LUMINANCE8_SGIS,

		/// <summary>
		/// Strongly typed for value GL_RED, GL_RED_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Red = Gl.RED,

		/// <summary>
		/// Strongly typed for value GL_R8, GL_R8_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		R8 = Gl.R8,

		/// <summary>
		/// Strongly typed for value GL_R8_SNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		R8Snorm = Gl.R8_SNORM,

		/// <summary>
		/// Strongly typed for value GL_R16, GL_R16_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		R16 = Gl.R16,

		/// <summary>
		/// Strongly typed for value GL_R16_SNORM, GL_R16_SNORM_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		R16Snorm = Gl.R16_SNORM,

		/// <summary>
		/// Strongly typed for value GL_R16F, GL_R16F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		R16f = Gl.R16F,

		/// <summary>
		/// Strongly typed for value GL_R32F, GL_R32F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		R32f = Gl.R32F,

		/// <summary>
		/// Strongly typed for value GL_R8I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R8i = Gl.R8I,

		/// <summary>
		/// Strongly typed for value GL_R16I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R16i = Gl.R16I,

		/// <summary>
		/// Strongly typed for value GL_R32I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R32i = Gl.R32I,

		/// <summary>
		/// Strongly typed for value GL_R8UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R8ui = Gl.R8UI,

		/// <summary>
		/// Strongly typed for value GL_R16UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R16ui = Gl.R16UI,

		/// <summary>
		/// Strongly typed for value GL_R32UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		R32ui = Gl.R32UI,

		/// <summary>
		/// Strongly typed for value GL_RG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		Rg = Gl.RG,

		/// <summary>
		/// Strongly typed for value GL_RG8, GL_RG8_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rg8 = Gl.RG8,

		/// <summary>
		/// Strongly typed for value GL_RG8_SNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		Rg8Snorm = Gl.RG8_SNORM,

		/// <summary>
		/// Strongly typed for value GL_RG16, GL_RG16_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		Rg16 = Gl.RG16,

		/// <summary>
		/// Strongly typed for value GL_RG16_SNORM, GL_RG16_SNORM_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		Rg16Snorm = Gl.RG16_SNORM,

		/// <summary>
		/// Strongly typed for value GL_RG16F, GL_RG16F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rg16f = Gl.RG16F,

		/// <summary>
		/// Strongly typed for value GL_RG32F, GL_RG32F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rg32f = Gl.RG32F,

		/// <summary>
		/// Strongly typed for value GL_RG8I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg8i = Gl.RG8I,

		/// <summary>
		/// Strongly typed for value GL_RG16I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg16i = Gl.RG16I,

		/// <summary>
		/// Strongly typed for value GL_RG32I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg32i = Gl.RG32I,

		/// <summary>
		/// Strongly typed for value GL_RG8UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg8ui = Gl.RG8UI,

		/// <summary>
		/// Strongly typed for value GL_RG16UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg16ui = Gl.RG16UI,

		/// <summary>
		/// Strongly typed for value GL_RG32UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		Rg32ui = Gl.RG32UI,

		/// <summary>
		/// Strongly typed for value GL_RGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgb = Gl.RGB,

		/// <summary>
		/// Strongly typed for value GL_RGB2_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		Rgb2Ext = Gl.RGB2_EXT,

		/// <summary>
		/// Strongly typed for value GL_RGB4, GL_RGB4_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		Rgb4 = Gl.RGB4,

		/// <summary>
		/// Strongly typed for value GL_RGB5, GL_RGB5_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		Rgb5 = Gl.RGB5,

		/// <summary>
		/// Strongly typed for value GL_RGB8, GL_RGB8_EXT, GL_RGB8_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_rgb8_rgba8", Api = "gles1|gles2|glsc2")]
		Rgb8 = Gl.RGB8,

		/// <summary>
		/// Strongly typed for value GL_RGB8_SNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		Rgb8Snorm = Gl.RGB8_SNORM,

		/// <summary>
		/// Strongly typed for value GL_RGB10, GL_RGB10_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		Rgb10 = Gl.RGB10,

		/// <summary>
		/// Strongly typed for value GL_RGB12, GL_RGB12_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		Rgb12 = Gl.RGB12,

		/// <summary>
		/// Strongly typed for value GL_RGB16, GL_RGB16_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		Rgb16 = Gl.RGB16,

		/// <summary>
		/// Strongly typed for value GL_RGB16F, GL_RGB16F_ARB, GL_RGB16F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rgb16f = Gl.RGB16F,

		/// <summary>
		/// Strongly typed for value GL_RGB16_SNORM, GL_RGB16_SNORM_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		Rgb16Snorm = Gl.RGB16_SNORM,

		/// <summary>
		/// Strongly typed for value GL_RGB8I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb8i = Gl.RGB8I,

		/// <summary>
		/// Strongly typed for value GL_RGB16I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb16i = Gl.RGB16I,

		/// <summary>
		/// Strongly typed for value GL_RGB32I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_vertex_attrib_64bit", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb32i = Gl.RGB32I,

		/// <summary>
		/// Strongly typed for value GL_RGB8UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb8ui = Gl.RGB8UI,

		/// <summary>
		/// Strongly typed for value GL_RGB16UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb16ui = Gl.RGB16UI,

		/// <summary>
		/// Strongly typed for value GL_RGB32UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_buffer_object_rgb32", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgb32ui = Gl.RGB32UI,

		/// <summary>
		/// Strongly typed for value GL_SRGB, GL_SRGB_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		Srgb = Gl.SRGB,

		/// <summary>
		/// Strongly typed for value GL_SRGB_ALPHA, GL_SRGB_ALPHA_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		SrgbAlpha = Gl.SRGB_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_SRGB8, GL_SRGB8_EXT, GL_SRGB8_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		[RequiredByFeature("GL_NV_sRGB_formats", Api = "gles2")]
		Srgb8 = Gl.SRGB8,

		/// <summary>
		/// Strongly typed for value GL_SRGB8_ALPHA8, GL_SRGB8_ALPHA8_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_sRGB", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		Srgb8Alpha8 = Gl.SRGB8_ALPHA8,

		/// <summary>
		/// Strongly typed for value GL_R3_G3_B2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		R3G3B2 = Gl.R3_G3_B2,

		/// <summary>
		/// Strongly typed for value GL_R11F_G11F_B10F, GL_R11F_G11F_B10F_APPLE, GL_R11F_G11F_B10F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_float")]
		R11fG11fB10f = Gl.R11F_G11F_B10F,

		/// <summary>
		/// Strongly typed for value GL_RGB9_E5, GL_RGB9_E5_APPLE, GL_RGB9_E5_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_shared_exponent")]
		Rgb9E5 = Gl.RGB9_E5,

		/// <summary>
		/// Strongly typed for value GL_RGBA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgba = Gl.RGBA,

		/// <summary>
		/// Strongly typed for value GL_RGBA4, GL_RGBA4_EXT, GL_RGBA4_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		Rgba4 = Gl.RGBA4,

		/// <summary>
		/// Strongly typed for value GL_RGB5_A1, GL_RGB5_A1_EXT, GL_RGB5_A1_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		Rgb5A1 = Gl.RGB5_A1,

		/// <summary>
		/// Strongly typed for value GL_RGBA8, GL_RGBA8_EXT, GL_RGBA8_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_rgb8_rgba8", Api = "gles1|gles2|glsc2")]
		Rgba8 = Gl.RGBA8,

		/// <summary>
		/// Strongly typed for value GL_RGBA8_SNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_snorm")]
		Rgba8Snorm = Gl.RGBA8_SNORM,

		/// <summary>
		/// Strongly typed for value GL_RGB10_A2, GL_RGB10_A2_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		Rgb10A2 = Gl.RGB10_A2,

		/// <summary>
		/// Strongly typed for value GL_RGBA12, GL_RGBA12_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		Rgba12 = Gl.RGBA12,

		/// <summary>
		/// Strongly typed for value GL_RGBA16, GL_RGBA16_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RequiredByFeature("GL_EXT_texture_norm16", Api = "gles2")]
		Rgba16 = Gl.RGBA16,

		/// <summary>
		/// Strongly typed for value GL_RGBA16F, GL_RGBA16F_ARB, GL_RGBA16F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_color_buffer_half_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rgba16f = Gl.RGBA16F,

		/// <summary>
		/// Strongly typed for value GL_RGBA32F, GL_RGBA32F_ARB, GL_RGBA32F_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_float")]
		[RequiredByFeature("GL_EXT_texture_storage", Api = "gles1|gles2")]
		Rgba32f = Gl.RGBA32F,

		/// <summary>
		/// Strongly typed for value GL_RGBA8I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba8i = Gl.RGBA8I,

		/// <summary>
		/// Strongly typed for value GL_RGBA16I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba16i = Gl.RGBA16I,

		/// <summary>
		/// Strongly typed for value GL_RGBA32I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba32i = Gl.RGBA32I,

		/// <summary>
		/// Strongly typed for value GL_RGBA8UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba8ui = Gl.RGBA8UI,

		/// <summary>
		/// Strongly typed for value GL_RGBA16UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba16ui = Gl.RGBA16UI,

		/// <summary>
		/// Strongly typed for value GL_RGBA32UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		Rgba32ui = Gl.RGBA32UI,

		/// <summary>
		/// Strongly typed for value GL_RGB10_A2UI.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rgb10_a2ui", Api = "gl|glcore")]
		Rgb10A2ui = Gl.RGB10_A2UI,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		DepthComponent = Gl.DEPTH_COMPONENT,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT16, GL_DEPTH_COMPONENT16_ARB, GL_DEPTH_COMPONENT16_OES, 
		/// GL_DEPTH_COMPONENT16_SGIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		DepthComponent16 = Gl.DEPTH_COMPONENT16,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT24_ARB, GL_DEPTH_COMPONENT24_OES, GL_DEPTH_COMPONENT24_SGIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_OES_depth24", Api = "gles1|gles2|glsc2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		DepthComponent24 = Gl.DEPTH_COMPONENT24,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT32_ARB, GL_DEPTH_COMPONENT32_OES, GL_DEPTH_COMPONENT32_SGIX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ARB_depth_texture")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth32", Api = "gles1|gles2|glsc2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIX_depth_texture")]
		DepthComponent32 = Gl.DEPTH_COMPONENT32,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT32F.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
		DepthComponent32f = Gl.DEPTH_COMPONENT32F,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT32F_NV, GL_DEPTH_COMPONENT32F_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		DepthComponent32fNv = Gl.DEPTH_COMPONENT32F_NV,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_STENCIL, GL_DEPTH_STENCIL_EXT, GL_DEPTH_STENCIL_NV, GL_DEPTH_STENCIL_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_NV_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		DepthStencil = Gl.DEPTH_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_DEPTH24_STENCIL8, GL_DEPTH24_STENCIL8_EXT, GL_DEPTH24_STENCIL8_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		[RequiredByFeature("GL_OES_required_internalformat", Api = "gles1|gles2")]
		Depth24Stencil8 = Gl.DEPTH24_STENCIL8,

		/// <summary>
		/// Strongly typed for value GL_DEPTH32F_STENCIL8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_depth_buffer_float", Api = "gl|glcore")]
		Depth32fStencil8 = Gl.DEPTH32F_STENCIL8,

		/// <summary>
		/// Strongly typed for value GL_DEPTH32F_STENCIL8_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_depth_buffer_float")]
		Depth32fStencil8Nv = Gl.DEPTH32F_STENCIL8_NV,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		CompressedRed = Gl.COMPRESSED_RED,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		CompressedRg = Gl.COMPRESSED_RG,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		CompressedRgb = Gl.COMPRESSED_RGB,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGBA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		CompressedRgba = Gl.COMPRESSED_RGBA,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		CompressedSrgb = Gl.COMPRESSED_SRGB,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_1")]
		[RequiredByFeature("GL_EXT_texture_sRGB")]
		CompressedSrgbAlpha = Gl.COMPRESSED_SRGB_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RED_RGTC1, GL_COMPRESSED_RED_RGTC1_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_compression_rgtc")]
		CompressedRedRgtc1 = Gl.COMPRESSED_RED_RGTC1,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SIGNED_RED_RGTC1, GL_COMPRESSED_SIGNED_RED_RGTC1_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_compression_rgtc")]
		CompressedSignedRedRgtc1 = Gl.COMPRESSED_SIGNED_RED_RGTC1,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_R11_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedR11Eac = Gl.COMPRESSED_R11_EAC,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SIGNED_R11_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedSignedR11Eac = Gl.COMPRESSED_SIGNED_R11_EAC,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RG_RGTC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		CompressedRgRgtc2 = Gl.COMPRESSED_RG_RGTC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SIGNED_RG_RGTC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_texture_compression_rgtc", Api = "gl|glcore")]
		CompressedSignedRgRgtc2 = Gl.COMPRESSED_SIGNED_RG_RGTC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGBA_BPTC_UNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		CompressedRgbaBptcUnorm = Gl.COMPRESSED_RGBA_BPTC_UNORM,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB_ALPHA_BPTC_UNORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		CompressedSrgbAlphaBptcUnorm = Gl.COMPRESSED_SRGB_ALPHA_BPTC_UNORM,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGB_BPTC_SIGNED_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		CompressedRgbBptcSignedFloat = Gl.COMPRESSED_RGB_BPTC_SIGNED_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_texture_compression_bptc", Api = "gl|glcore")]
		CompressedRgbBptcUnsignedFloat = Gl.COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGB8_ETC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedRgb8Etc2 = Gl.COMPRESSED_RGB8_ETC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB8_ETC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedSrgb8Etc2 = Gl.COMPRESSED_SRGB8_ETC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedRgb8PunchthroughAlpha1Etc2 = Gl.COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedSrgb8PunchthroughAlpha1Etc2 = Gl.COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RGBA8_ETC2_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedRgba8Etc2Eac = Gl.COMPRESSED_RGBA8_ETC2_EAC,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SRGB8_ALPHA8_ETC2_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedSrgb8Alpha8Etc2Eac = Gl.COMPRESSED_SRGB8_ALPHA8_ETC2_EAC,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_RG11_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedRg11Eac = Gl.COMPRESSED_RG11_EAC,

		/// <summary>
		/// Strongly typed for value GL_COMPRESSED_SIGNED_RG11_EAC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		CompressedSignedRg11Eac = Gl.COMPRESSED_SIGNED_RG11_EAC,

	}

	/// <summary>
	/// Strongly typed enumeration InternalFormatPName.
	/// </summary>
	public enum InternalFormatPName
	{
		/// <summary>
		/// Strongly typed for value GL_NUM_SAMPLE_COUNTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		NumSampleCounts = Gl.NUM_SAMPLE_COUNTS,

		/// <summary>
		/// Strongly typed for value GL_SAMPLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_multisample")]
		[RequiredByFeature("GL_NV_multisample_coverage")]
		[RequiredByFeature("GL_EXT_multisample")]
		[RequiredByFeature("GL_SGIS_multisample")]
		Samples = Gl.SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_SUPPORTED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatSupported = Gl.INTERNALFORMAT_SUPPORTED,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_PREFERRED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatPreferred = Gl.INTERNALFORMAT_PREFERRED,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatRedSize = Gl.INTERNALFORMAT_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatGreenSize = Gl.INTERNALFORMAT_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatBlueSize = Gl.INTERNALFORMAT_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatAlphaSize = Gl.INTERNALFORMAT_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_DEPTH_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatDepthSize = Gl.INTERNALFORMAT_DEPTH_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_STENCIL_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatStencilSize = Gl.INTERNALFORMAT_STENCIL_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_SHARED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatSharedSize = Gl.INTERNALFORMAT_SHARED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_RED_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatRedType = Gl.INTERNALFORMAT_RED_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_GREEN_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatGreenType = Gl.INTERNALFORMAT_GREEN_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_BLUE_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatBlueType = Gl.INTERNALFORMAT_BLUE_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_ALPHA_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatAlphaType = Gl.INTERNALFORMAT_ALPHA_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_DEPTH_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatDepthType = Gl.INTERNALFORMAT_DEPTH_TYPE,

		/// <summary>
		/// Strongly typed for value GL_INTERNALFORMAT_STENCIL_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		InternalformatStencilType = Gl.INTERNALFORMAT_STENCIL_TYPE,

		/// <summary>
		/// Strongly typed for value GL_MAX_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		MaxWidth = Gl.MAX_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		MaxHeight = Gl.MAX_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_MAX_DEPTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		MaxDepth = Gl.MAX_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_LAYERS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		MaxLayers = Gl.MAX_LAYERS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_COMPONENTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ColorComponents = Gl.COLOR_COMPONENTS,

		/// <summary>
		/// Strongly typed for value GL_COLOR_RENDERABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ColorRenderable = Gl.COLOR_RENDERABLE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_RENDERABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		DepthRenderable = Gl.DEPTH_RENDERABLE,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_RENDERABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		StencilRenderable = Gl.STENCIL_RENDERABLE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_RENDERABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		FramebufferRenderable = Gl.FRAMEBUFFER_RENDERABLE,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_RENDERABLE_LAYERED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		FramebufferRenderableLayered = Gl.FRAMEBUFFER_RENDERABLE_LAYERED,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_BLEND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		FramebufferBlend = Gl.FRAMEBUFFER_BLEND,

		/// <summary>
		/// Strongly typed for value GL_READ_PIXELS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ReadPixels = Gl.READ_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_READ_PIXELS_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ReadPixelsFormat = Gl.READ_PIXELS_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_READ_PIXELS_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ReadPixelsType = Gl.READ_PIXELS_TYPE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_IMAGE_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureImageFormat = Gl.TEXTURE_IMAGE_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_IMAGE_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureImageType = Gl.TEXTURE_IMAGE_TYPE,

		/// <summary>
		/// Strongly typed for value GL_GET_TEXTURE_IMAGE_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		GetTextureImageFormat = Gl.GET_TEXTURE_IMAGE_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_GET_TEXTURE_IMAGE_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		GetTextureImageType = Gl.GET_TEXTURE_IMAGE_TYPE,

		/// <summary>
		/// Strongly typed for value GL_MIPMAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		Mipmap = Gl.MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GenerateMipmap = Gl.GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_AUTO_GENERATE_MIPMAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		AutoGenerateMipmap = Gl.AUTO_GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ENCODING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ColorEncoding = Gl.COLOR_ENCODING,

		/// <summary>
		/// Strongly typed for value GL_SRGB_READ.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SrgbRead = Gl.SRGB_READ,

		/// <summary>
		/// Strongly typed for value GL_SRGB_WRITE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SrgbWrite = Gl.SRGB_WRITE,

		/// <summary>
		/// Strongly typed for value GL_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		Filter = Gl.FILTER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		VertexTexture = Gl.VERTEX_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TessControlTexture = Gl.TESS_CONTROL_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TessEvaluationTexture = Gl.TESS_EVALUATION_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		GeometryTexture = Gl.GEOMETRY_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		FragmentTexture = Gl.FRAGMENT_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_COMPUTE_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ComputeTexture = Gl.COMPUTE_TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SHADOW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureShadow = Gl.TEXTURE_SHADOW,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GATHER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureGather = Gl.TEXTURE_GATHER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GATHER_SHADOW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureGatherShadow = Gl.TEXTURE_GATHER_SHADOW,

		/// <summary>
		/// Strongly typed for value GL_SHADER_IMAGE_LOAD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ShaderImageLoad = Gl.SHADER_IMAGE_LOAD,

		/// <summary>
		/// Strongly typed for value GL_SHADER_IMAGE_STORE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ShaderImageStore = Gl.SHADER_IMAGE_STORE,

		/// <summary>
		/// Strongly typed for value GL_SHADER_IMAGE_ATOMIC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ShaderImageAtomic = Gl.SHADER_IMAGE_ATOMIC,

		/// <summary>
		/// Strongly typed for value GL_IMAGE_TEXEL_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ImageTexelSize = Gl.IMAGE_TEXEL_SIZE,

		/// <summary>
		/// Strongly typed for value GL_IMAGE_COMPATIBILITY_CLASS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ImageCompatibilityClass = Gl.IMAGE_COMPATIBILITY_CLASS,

		/// <summary>
		/// Strongly typed for value GL_IMAGE_PIXEL_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ImagePixelFormat = Gl.IMAGE_PIXEL_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_IMAGE_PIXEL_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ImagePixelType = Gl.IMAGE_PIXEL_TYPE,

		/// <summary>
		/// Strongly typed for value GL_IMAGE_FORMAT_COMPATIBILITY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		ImageFormatCompatibilityType = Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SimultaneousTextureAndDepthTest = Gl.SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST,

		/// <summary>
		/// Strongly typed for value GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SimultaneousTextureAndStencilTest = Gl.SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST,

		/// <summary>
		/// Strongly typed for value GL_SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SimultaneousTextureAndDepthWrite = Gl.SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE,

		/// <summary>
		/// Strongly typed for value GL_SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		SimultaneousTextureAndStencilWrite = Gl.SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_compression")]
		TextureCompressed = Gl.TEXTURE_COMPRESSED,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSED_BLOCK_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureCompressedBlockWidth = Gl.TEXTURE_COMPRESSED_BLOCK_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSED_BLOCK_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureCompressedBlockHeight = Gl.TEXTURE_COMPRESSED_BLOCK_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPRESSED_BLOCK_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureCompressedBlockSize = Gl.TEXTURE_COMPRESSED_BLOCK_SIZE,

		/// <summary>
		/// Strongly typed for value GL_CLEAR_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ClearBuffer = Gl.CLEAR_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_VIEW.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		TextureView = Gl.TEXTURE_VIEW,

		/// <summary>
		/// Strongly typed for value GL_VIEW_COMPATIBILITY_CLASS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		ViewCompatibilityClass = Gl.VIEW_COMPATIBILITY_CLASS,

		/// <summary>
		/// Strongly typed for value GL_CLEAR_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_clear_texture", Api = "gl|glcore")]
		ClearTexture = Gl.CLEAR_TEXTURE,

	}

	/// <summary>
	/// Strongly typed enumeration LightEnvModeSGIX.
	/// </summary>
	public enum LightEnvModeSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Add = Gl.ADD,

		/// <summary>
		/// Strongly typed for value GL_MODULATE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Modulate = Gl.MODULATE,

		/// <summary>
		/// Strongly typed for value GL_REPLACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Replace = Gl.REPLACE,

	}

	/// <summary>
	/// Strongly typed enumeration LightEnvParameterSGIX.
	/// </summary>
	public enum LightEnvParameterSGIX
	{
		/// <summary>
		/// Strongly typed for value GL_LIGHT_ENV_MODE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		LightEnvModeSgix = Gl.LIGHT_ENV_MODE_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration LightModelColorControl.
	/// </summary>
	public enum LightModelColorControl
	{
		/// <summary>
		/// Strongly typed for value GL_SEPARATE_SPECULAR_COLOR, GL_SEPARATE_SPECULAR_COLOR_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SeparateSpecularColor = Gl.SEPARATE_SPECULAR_COLOR,

		/// <summary>
		/// Strongly typed for value GL_SINGLE_COLOR, GL_SINGLE_COLOR_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SingleColor = Gl.SINGLE_COLOR,

	}

	/// <summary>
	/// Strongly typed enumeration LightModelParameter.
	/// </summary>
	public enum LightModelParameter
	{
		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_AMBIENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelAmbient = Gl.LIGHT_MODEL_AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_COLOR_CONTROL, GL_LIGHT_MODEL_COLOR_CONTROL_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_separate_specular_color")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelColorControl = Gl.LIGHT_MODEL_COLOR_CONTROL,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_LOCAL_VIEWER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelLocalViewer = Gl.LIGHT_MODEL_LOCAL_VIEWER,

		/// <summary>
		/// Strongly typed for value GL_LIGHT_MODEL_TWO_SIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LightModelTwoSide = Gl.LIGHT_MODEL_TWO_SIDE,

	}

	/// <summary>
	/// Strongly typed enumeration LightName.
	/// </summary>
	public enum LightName
	{
		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT0_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight0Sgix = Gl.FRAGMENT_LIGHT0_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT1_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight1Sgix = Gl.FRAGMENT_LIGHT1_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT2_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight2Sgix = Gl.FRAGMENT_LIGHT2_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT3_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight3Sgix = Gl.FRAGMENT_LIGHT3_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT4_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight4Sgix = Gl.FRAGMENT_LIGHT4_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT5_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight5Sgix = Gl.FRAGMENT_LIGHT5_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT6_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight6Sgix = Gl.FRAGMENT_LIGHT6_SGIX,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_LIGHT7_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_fragment_lighting")]
		FragmentLight7Sgix = Gl.FRAGMENT_LIGHT7_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LIGHT0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light0 = Gl.LIGHT0,

		/// <summary>
		/// Strongly typed for value GL_LIGHT1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light1 = Gl.LIGHT1,

		/// <summary>
		/// Strongly typed for value GL_LIGHT2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light2 = Gl.LIGHT2,

		/// <summary>
		/// Strongly typed for value GL_LIGHT3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light3 = Gl.LIGHT3,

		/// <summary>
		/// Strongly typed for value GL_LIGHT4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light4 = Gl.LIGHT4,

		/// <summary>
		/// Strongly typed for value GL_LIGHT5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light5 = Gl.LIGHT5,

		/// <summary>
		/// Strongly typed for value GL_LIGHT6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light6 = Gl.LIGHT6,

		/// <summary>
		/// Strongly typed for value GL_LIGHT7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Light7 = Gl.LIGHT7,

	}

	/// <summary>
	/// Strongly typed enumeration LightParameter.
	/// </summary>
	public enum LightParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_CONSTANT_ATTENUATION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ConstantAttenuation = Gl.CONSTANT_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_ATTENUATION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LinearAttenuation = Gl.LINEAR_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_POSITION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Position = Gl.POSITION,

		/// <summary>
		/// Strongly typed for value GL_QUADRATIC_ATTENUATION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		QuadraticAttenuation = Gl.QUADRATIC_ATTENUATION,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Specular = Gl.SPECULAR,

		/// <summary>
		/// Strongly typed for value GL_SPOT_CUTOFF.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SpotCutoff = Gl.SPOT_CUTOFF,

		/// <summary>
		/// Strongly typed for value GL_SPOT_DIRECTION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SpotDirection = Gl.SPOT_DIRECTION,

		/// <summary>
		/// Strongly typed for value GL_SPOT_EXPONENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SpotExponent = Gl.SPOT_EXPONENT,

	}

	/// <summary>
	/// Strongly typed enumeration ListMode.
	/// </summary>
	public enum ListMode
	{
		/// <summary>
		/// Strongly typed for value GL_COMPILE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Compile = Gl.COMPILE,

		/// <summary>
		/// Strongly typed for value GL_COMPILE_AND_EXECUTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		CompileAndExecute = Gl.COMPILE_AND_EXECUTE,

	}

	/// <summary>
	/// Strongly typed enumeration ListNameType.
	/// </summary>
	public enum ListNameType
	{
		/// <summary>
		/// Strongly typed for value GL_2_BYTES.
		/// </summary>
		_2Bytes = Gl._2_BYTES,

		/// <summary>
		/// Strongly typed for value GL_3_BYTES.
		/// </summary>
		_3Bytes = Gl._3_BYTES,

		/// <summary>
		/// Strongly typed for value GL_4_BYTES.
		/// </summary>
		_4Bytes = Gl._4_BYTES,

		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration ListParameterName.
	/// </summary>
	public enum ListParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_LIST_PRIORITY_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_list_priority")]
		ListPrioritySgix = Gl.LIST_PRIORITY_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration LogicOp.
	/// </summary>
	public enum LogicOp
	{
		/// <summary>
		/// Strongly typed for value GL_AND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		And = Gl.AND,

		/// <summary>
		/// Strongly typed for value GL_AND_INVERTED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		AndInverted = Gl.AND_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_AND_REVERSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		AndReverse = Gl.AND_REVERSE,

		/// <summary>
		/// Strongly typed for value GL_CLEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Clear = Gl.CLEAR,

		/// <summary>
		/// Strongly typed for value GL_COPY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Copy = Gl.COPY,

		/// <summary>
		/// Strongly typed for value GL_COPY_INVERTED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		CopyInverted = Gl.COPY_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_EQUIV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Equiv = Gl.EQUIV,

		/// <summary>
		/// Strongly typed for value GL_INVERT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Invert = Gl.INVERT,

		/// <summary>
		/// Strongly typed for value GL_NAND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Nand = Gl.NAND,

		/// <summary>
		/// Strongly typed for value GL_NOOP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Noop = Gl.NOOP,

		/// <summary>
		/// Strongly typed for value GL_NOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Nor = Gl.NOR,

		/// <summary>
		/// Strongly typed for value GL_OR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Or = Gl.OR,

		/// <summary>
		/// Strongly typed for value GL_OR_INVERTED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		OrInverted = Gl.OR_INVERTED,

		/// <summary>
		/// Strongly typed for value GL_OR_REVERSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		OrReverse = Gl.OR_REVERSE,

		/// <summary>
		/// Strongly typed for value GL_SET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		Set = Gl.SET,

		/// <summary>
		/// Strongly typed for value GL_XOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Xor = Gl.XOR,

	}

	/// <summary>
	/// Strongly typed enumeration MapBufferUsageMask.
	/// </summary>
	[Flags()]
	public enum MapBufferUsageMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_CLIENT_STORAGE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		ClientStorageBit = Gl.CLIENT_STORAGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_DYNAMIC_STORAGE_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		DynamicStorageBit = Gl.DYNAMIC_STORAGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_COHERENT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		MapCoherentBit = Gl.MAP_COHERENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_FLUSH_EXPLICIT_BIT, GL_MAP_FLUSH_EXPLICIT_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapFlushExplicitBit = Gl.MAP_FLUSH_EXPLICIT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_INVALIDATE_BUFFER_BIT, GL_MAP_INVALIDATE_BUFFER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapInvalidateBufferBit = Gl.MAP_INVALIDATE_BUFFER_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_INVALIDATE_RANGE_BIT, GL_MAP_INVALIDATE_RANGE_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapInvalidateRangeBit = Gl.MAP_INVALIDATE_RANGE_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_PERSISTENT_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		MapPersistentBit = Gl.MAP_PERSISTENT_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_READ_BIT, GL_MAP_READ_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapReadBit = Gl.MAP_READ_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_UNSYNCHRONIZED_BIT, GL_MAP_UNSYNCHRONIZED_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapUnsynchronizedBit = Gl.MAP_UNSYNCHRONIZED_BIT,

		/// <summary>
		/// Strongly typed for value GL_MAP_WRITE_BIT, GL_MAP_WRITE_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_map_buffer_range", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		[RequiredByFeature("GL_EXT_map_buffer_range", Api = "gles1|gles2")]
		MapWriteBit = Gl.MAP_WRITE_BIT,

		/// <summary>
		/// Strongly typed for value GL_NONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		None = Gl.NONE,

	}

	/// <summary>
	/// Strongly typed enumeration MapTextureFormatINTEL.
	/// </summary>
	public enum MapTextureFormatINTEL
	{
		/// <summary>
		/// Strongly typed for value GL_LAYOUT_DEFAULT_INTEL.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		LayoutDefaultIntel = Gl.LAYOUT_DEFAULT_INTEL,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_LINEAR_CPU_CACHED_INTEL.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		LayoutLinearCpuCachedIntel = Gl.LAYOUT_LINEAR_CPU_CACHED_INTEL,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_LINEAR_INTEL.
		/// </summary>
		[RequiredByFeature("GL_INTEL_map_texture")]
		LayoutLinearIntel = Gl.LAYOUT_LINEAR_INTEL,

	}

	/// <summary>
	/// Strongly typed enumeration MaterialFace.
	/// </summary>
	public enum MaterialFace
	{
		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration MaterialParameter.
	/// </summary>
	public enum MaterialParameter
	{
		/// <summary>
		/// Strongly typed for value GL_AMBIENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Ambient = Gl.AMBIENT,

		/// <summary>
		/// Strongly typed for value GL_AMBIENT_AND_DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AmbientAndDiffuse = Gl.AMBIENT_AND_DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_COLOR_INDEXES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorIndexes = Gl.COLOR_INDEXES,

		/// <summary>
		/// Strongly typed for value GL_DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Diffuse = Gl.DIFFUSE,

		/// <summary>
		/// Strongly typed for value GL_EMISSION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Emission = Gl.EMISSION,

		/// <summary>
		/// Strongly typed for value GL_SHININESS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Shininess = Gl.SHININESS,

		/// <summary>
		/// Strongly typed for value GL_SPECULAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Specular = Gl.SPECULAR,

	}

	/// <summary>
	/// Strongly typed enumeration MatrixMode.
	/// </summary>
	public enum MatrixMode
	{
		/// <summary>
		/// Strongly typed for value GL_MODELVIEW, GL_MODELVIEW0_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Modelview = Gl.MODELVIEW,

		/// <summary>
		/// Strongly typed for value GL_PROJECTION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Projection = Gl.PROJECTION,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Texture = Gl.TEXTURE,

	}

	/// <summary>
	/// Strongly typed enumeration MemoryBarrierMask.
	/// </summary>
	[Flags()]
	public enum MemoryBarrierMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_ALL_BARRIER_BITS, GL_ALL_BARRIER_BITS_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		AllBarrierBits = Gl.ALL_BARRIER_BITS,

		/// <summary>
		/// Strongly typed for value GL_ATOMIC_COUNTER_BARRIER_BIT, GL_ATOMIC_COUNTER_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		AtomicCounterBarrierBit = Gl.ATOMIC_COUNTER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_UPDATE_BARRIER_BIT, GL_BUFFER_UPDATE_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		BufferUpdateBarrierBit = Gl.BUFFER_UPDATE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_CLIENT_MAPPED_BUFFER_BARRIER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		ClientMappedBufferBarrierBit = Gl.CLIENT_MAPPED_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COMMAND_BARRIER_BIT, GL_COMMAND_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		CommandBarrierBit = Gl.COMMAND_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ELEMENT_ARRAY_BARRIER_BIT, GL_ELEMENT_ARRAY_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		ElementArrayBarrierBit = Gl.ELEMENT_ARRAY_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER_BARRIER_BIT, GL_FRAMEBUFFER_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		FramebufferBarrierBit = Gl.FRAMEBUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_BUFFER_BARRIER_BIT, GL_PIXEL_BUFFER_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		PixelBufferBarrierBit = Gl.PIXEL_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_QUERY_BUFFER_BARRIER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		QueryBufferBarrierBit = Gl.QUERY_BUFFER_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV.
		/// </summary>
		[RequiredByFeature("GL_NV_shader_buffer_store", Api = "gl|glcore")]
		ShaderGlobalAccessBarrierBitNv = Gl.SHADER_GLOBAL_ACCESS_BARRIER_BIT_NV,

		/// <summary>
		/// Strongly typed for value GL_SHADER_IMAGE_ACCESS_BARRIER_BIT, GL_SHADER_IMAGE_ACCESS_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		ShaderImageAccessBarrierBit = Gl.SHADER_IMAGE_ACCESS_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_SHADER_STORAGE_BARRIER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_storage_buffer_object", Api = "gl|glcore")]
		ShaderStorageBarrierBit = Gl.SHADER_STORAGE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_FETCH_BARRIER_BIT, GL_TEXTURE_FETCH_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		TextureFetchBarrierBit = Gl.TEXTURE_FETCH_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_UPDATE_BARRIER_BIT, GL_TEXTURE_UPDATE_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		TextureUpdateBarrierBit = Gl.TEXTURE_UPDATE_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BARRIER_BIT, GL_TRANSFORM_FEEDBACK_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		TransformFeedbackBarrierBit = Gl.TRANSFORM_FEEDBACK_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BARRIER_BIT, GL_UNIFORM_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		UniformBarrierBit = Gl.UNIFORM_BARRIER_BIT,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT, GL_VERTEX_ATTRIB_ARRAY_BARRIER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_image_load_store", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_shader_image_load_store")]
		VertexAttribArrayBarrierBit = Gl.VERTEX_ATTRIB_ARRAY_BARRIER_BIT,

	}

	/// <summary>
	/// Strongly typed enumeration MemoryObjectParameterName.
	/// </summary>
	public enum MemoryObjectParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_DEDICATED_MEMORY_OBJECT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		DedicatedMemoryObjectExt = Gl.DEDICATED_MEMORY_OBJECT_EXT,

		/// <summary>
		/// Strongly typed for value GL_PROTECTED_MEMORY_OBJECT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		ProtectedMemoryObjectExt = Gl.PROTECTED_MEMORY_OBJECT_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration MeshMode1.
	/// </summary>
	public enum MeshMode1
	{
		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration MeshMode2.
	/// </summary>
	public enum MeshMode2
	{
		/// <summary>
		/// Strongly typed for value GL_FILL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Fill = Gl.FILL,

		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration MinmaxTarget.
	/// </summary>
	public enum MinmaxTarget
	{
		/// <summary>
		/// Strongly typed for value GL_MINMAX, GL_MINMAX_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_histogram")]
		Minmax = Gl.MINMAX,

	}

	/// <summary>
	/// Strongly typed enumeration NormalPointerType.
	/// </summary>
	public enum NormalPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration PatchParameterName.
	/// </summary>
	public enum PatchParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_PATCH_VERTICES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		PatchVertices = Gl.PATCH_VERTICES,

		/// <summary>
		/// Strongly typed for value GL_PATCH_DEFAULT_OUTER_LEVEL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		PatchDefaultOuterLevel = Gl.PATCH_DEFAULT_OUTER_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_PATCH_DEFAULT_INNER_LEVEL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		PatchDefaultInnerLevel = Gl.PATCH_DEFAULT_INNER_LEVEL,

	}

	/// <summary>
	/// Strongly typed enumeration PixelCopyType.
	/// </summary>
	public enum PixelCopyType
	{
		/// <summary>
		/// Strongly typed for value GL_COLOR, GL_COLOR_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Color = Gl.COLOR,

		/// <summary>
		/// Strongly typed for value GL_DEPTH, GL_DEPTH_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Depth = Gl.DEPTH,

		/// <summary>
		/// Strongly typed for value GL_STENCIL, GL_STENCIL_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		Stencil = Gl.STENCIL,

	}

	/// <summary>
	/// Strongly typed enumeration PixelFormat.
	/// </summary>
	public enum PixelFormat
	{
		/// <summary>
		/// Strongly typed for value GL_ABGR_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_abgr")]
		AbgrExt = Gl.ABGR_EXT,

		/// <summary>
		/// Strongly typed for value GL_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		Alpha = Gl.ALPHA,

		/// <summary>
		/// Strongly typed for value GL_BLUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Blue = Gl.BLUE,

		/// <summary>
		/// Strongly typed for value GL_CMYKA_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		CmykaExt = Gl.CMYKA_EXT,

		/// <summary>
		/// Strongly typed for value GL_CMYK_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_cmyka")]
		CmykExt = Gl.CMYK_EXT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ColorIndex = Gl.COLOR_INDEX,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_COMPONENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		DepthComponent = Gl.DEPTH_COMPONENT,

		/// <summary>
		/// Strongly typed for value GL_GREEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Green = Gl.GREEN,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance = Gl.LUMINANCE,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LuminanceAlpha = Gl.LUMINANCE_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_RED, GL_RED_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Red = Gl.RED,

		/// <summary>
		/// Strongly typed for value GL_RGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgb = Gl.RGB,

		/// <summary>
		/// Strongly typed for value GL_RGBA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgba = Gl.RGBA,

		/// <summary>
		/// Strongly typed for value GL_STENCIL_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_stencil8", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_stencil8", Api = "gles2")]
		StencilIndex = Gl.STENCIL_INDEX,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_YCRCB_422_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_ycrcb")]
		Ycrcb422Sgix = Gl.YCRCB_422_SGIX,

		/// <summary>
		/// Strongly typed for value GL_YCRCB_444_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_ycrcb")]
		Ycrcb444Sgix = Gl.YCRCB_444_SGIX,

		/// <summary>
		/// Strongly typed for value GL_BGR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_bgra")]
		Bgr = Gl.BGR,

		/// <summary>
		/// Strongly typed for value GL_BGRA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ARB_vertex_array_bgra", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_array_bgra")]
		[RequiredByFeature("GL_APPLE_texture_format_BGRA8888", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_bgra")]
		[RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_texture_format_BGRA8888", Api = "gles1|gles2")]
		[RequiredByFeature("GL_IMG_read_format", Api = "gles1|gles2")]
		Bgra = Gl.BGRA,

		/// <summary>
		/// Strongly typed for value GL_RG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		Rg = Gl.RG,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_STENCIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_packed_depth_stencil")]
		[RequiredByFeature("GL_NV_packed_depth_stencil")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_packed_depth_stencil", Api = "gles1|gles2")]
		DepthStencil = Gl.DEPTH_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_RED_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		RedInteger = Gl.RED_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RG_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_rg", Api = "gl|glcore")]
		RgInteger = Gl.RG_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RGB_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		RgbInteger = Gl.RGB_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_RGBA_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_integer")]
		RgbaInteger = Gl.RGBA_INTEGER,

	}

	/// <summary>
	/// Strongly typed enumeration PixelMap.
	/// </summary>
	public enum PixelMap
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_A_TO_A.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapAToA = Gl.PIXEL_MAP_A_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_B_TO_B.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapBToB = Gl.PIXEL_MAP_B_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_G_TO_G.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapGToG = Gl.PIXEL_MAP_G_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_A.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToA = Gl.PIXEL_MAP_I_TO_A,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_B.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToB = Gl.PIXEL_MAP_I_TO_B,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_G.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToG = Gl.PIXEL_MAP_I_TO_G,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_I.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToI = Gl.PIXEL_MAP_I_TO_I,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_I_TO_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapIToR = Gl.PIXEL_MAP_I_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_R_TO_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapRToR = Gl.PIXEL_MAP_R_TO_R,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_MAP_S_TO_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PixelMapSToS = Gl.PIXEL_MAP_S_TO_S,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreParameter.
	/// </summary>
	public enum PixelStoreParameter
	{
		/// <summary>
		/// Strongly typed for value GL_PACK_ALIGNMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		PackAlignment = Gl.PACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		PackImageDepthSgis = Gl.PACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_IMAGE_HEIGHT, GL_PACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		PackImageHeight = Gl.PACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_PACK_LSB_FIRST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PackLsbFirst = Gl.PACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_OML.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		PackResampleOml = Gl.PACK_RESAMPLE_OML,

		/// <summary>
		/// Strongly typed for value GL_PACK_RESAMPLE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		PackResampleSgix = Gl.PACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_ROW_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackRowLength = Gl.PACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_IMAGES, GL_PACK_SKIP_IMAGES_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		PackSkipImages = Gl.PACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_PIXELS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackSkipPixels = Gl.PACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_ROWS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		PackSkipRows = Gl.PACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		PackSkipVolumesSgis = Gl.PACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		PackSubsampleRateSgix = Gl.PACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PACK_SWAP_BYTES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		PackSwapBytes = Gl.PACK_SWAP_BYTES,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_CACHE_SIZE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileCacheSizeSgix = Gl.PIXEL_TILE_CACHE_SIZE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridDepthSgix = Gl.PIXEL_TILE_GRID_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_HEIGHT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridHeightSgix = Gl.PIXEL_TILE_GRID_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_GRID_WIDTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileGridWidthSgix = Gl.PIXEL_TILE_GRID_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_HEIGHT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileHeightSgix = Gl.PIXEL_TILE_HEIGHT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_TILE_WIDTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_pixel_tiles")]
		PixelTileWidthSgix = Gl.PIXEL_TILE_WIDTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ALIGNMENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnpackAlignment = Gl.UNPACK_ALIGNMENT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_DEPTH_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		UnpackImageDepthSgis = Gl.UNPACK_IMAGE_DEPTH_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_IMAGE_HEIGHT, GL_UNPACK_IMAGE_HEIGHT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		UnpackImageHeight = Gl.UNPACK_IMAGE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_LSB_FIRST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		UnpackLsbFirst = Gl.UNPACK_LSB_FIRST,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_OML.
		/// </summary>
		[RequiredByFeature("GL_OML_resample")]
		UnpackResampleOml = Gl.UNPACK_RESAMPLE_OML,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_RESAMPLE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		UnpackResampleSgix = Gl.UNPACK_RESAMPLE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_ROW_LENGTH, GL_UNPACK_ROW_LENGTH_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackRowLength = Gl.UNPACK_ROW_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_IMAGES, GL_UNPACK_SKIP_IMAGES_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		UnpackSkipImages = Gl.UNPACK_SKIP_IMAGES,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_PIXELS, GL_UNPACK_SKIP_PIXELS_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackSkipPixels = Gl.UNPACK_SKIP_PIXELS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_ROWS, GL_UNPACK_SKIP_ROWS_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		UnpackSkipRows = Gl.UNPACK_SKIP_ROWS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SKIP_VOLUMES_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		UnpackSkipVolumesSgis = Gl.UNPACK_SKIP_VOLUMES_SGIS,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SUBSAMPLE_RATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		UnpackSubsampleRateSgix = Gl.UNPACK_SUBSAMPLE_RATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_UNPACK_SWAP_BYTES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		UnpackSwapBytes = Gl.UNPACK_SWAP_BYTES,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreResampleMode.
	/// </summary>
	public enum PixelStoreResampleMode
	{
		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_DECIMATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		ResampleDecimateSgix = Gl.RESAMPLE_DECIMATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_REPLICATE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		ResampleReplicateSgix = Gl.RESAMPLE_REPLICATE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_RESAMPLE_ZERO_FILL_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_resample")]
		ResampleZeroFillSgix = Gl.RESAMPLE_ZERO_FILL_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration PixelStoreSubsampleRate.
	/// </summary>
	public enum PixelStoreSubsampleRate
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_2424_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		PixelSubsample2424Sgix = Gl.PIXEL_SUBSAMPLE_2424_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_4242_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		PixelSubsample4242Sgix = Gl.PIXEL_SUBSAMPLE_4242_SGIX,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_SUBSAMPLE_4444_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_subsample")]
		PixelSubsample4444Sgix = Gl.PIXEL_SUBSAMPLE_4444_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTexGenMode.
	/// </summary>
	public enum PixelTexGenMode
	{
		/// <summary>
		/// Strongly typed for value GL_LUMINANCE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Luminance = Gl.LUMINANCE,

		/// <summary>
		/// Strongly typed for value GL_LUMINANCE_ALPHA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		LuminanceAlpha = Gl.LUMINANCE_ALPHA,

		/// <summary>
		/// Strongly typed for value GL_NONE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		None = Gl.NONE,

		/// <summary>
		/// Strongly typed for value GL_RGB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgb = Gl.RGB,

		/// <summary>
		/// Strongly typed for value GL_RGBA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Rgba = Gl.RGBA,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTexGenParameterNameSGIS.
	/// </summary>
	public enum PixelTexGenParameterNameSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		PixelFragmentAlphaSourceSgis = Gl.PIXEL_FRAGMENT_ALPHA_SOURCE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PIXEL_FRAGMENT_RGB_SOURCE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_pixel_texture")]
		PixelFragmentRgbSourceSgis = Gl.PIXEL_FRAGMENT_RGB_SOURCE_SGIS,

	}

	/// <summary>
	/// Strongly typed enumeration PixelTransferParameter.
	/// </summary>
	public enum PixelTransferParameter
	{
		/// <summary>
		/// Strongly typed for value GL_ALPHA_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaBias = Gl.ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_ALPHA_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		AlphaScale = Gl.ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_BLUE_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BlueBias = Gl.BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_BLUE_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		BlueScale = Gl.BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DepthBias = Gl.DEPTH_BIAS,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		DepthScale = Gl.DEPTH_SCALE,

		/// <summary>
		/// Strongly typed for value GL_GREEN_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GreenBias = Gl.GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_GREEN_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GreenScale = Gl.GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_INDEX_OFFSET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexOffset = Gl.INDEX_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_INDEX_SHIFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		IndexShift = Gl.INDEX_SHIFT,

		/// <summary>
		/// Strongly typed for value GL_MAP_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MapColor = Gl.MAP_COLOR,

		/// <summary>
		/// Strongly typed for value GL_MAP_STENCIL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		MapStencil = Gl.MAP_STENCIL,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_BIAS, GL_POST_COLOR_MATRIX_ALPHA_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixAlphaBias = Gl.POST_COLOR_MATRIX_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_ALPHA_SCALE, GL_POST_COLOR_MATRIX_ALPHA_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixAlphaScale = Gl.POST_COLOR_MATRIX_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_BIAS, GL_POST_COLOR_MATRIX_BLUE_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixBlueBias = Gl.POST_COLOR_MATRIX_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_BLUE_SCALE, GL_POST_COLOR_MATRIX_BLUE_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixBlueScale = Gl.POST_COLOR_MATRIX_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_BIAS, GL_POST_COLOR_MATRIX_GREEN_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixGreenBias = Gl.POST_COLOR_MATRIX_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_GREEN_SCALE, GL_POST_COLOR_MATRIX_GREEN_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixGreenScale = Gl.POST_COLOR_MATRIX_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_BIAS, GL_POST_COLOR_MATRIX_RED_BIAS_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixRedBias = Gl.POST_COLOR_MATRIX_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_COLOR_MATRIX_RED_SCALE, GL_POST_COLOR_MATRIX_RED_SCALE_SGI.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_SGI_color_matrix")]
		PostColorMatrixRedScale = Gl.POST_COLOR_MATRIX_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_BIAS, GL_POST_CONVOLUTION_ALPHA_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionAlphaBias = Gl.POST_CONVOLUTION_ALPHA_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_ALPHA_SCALE, GL_POST_CONVOLUTION_ALPHA_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionAlphaScale = Gl.POST_CONVOLUTION_ALPHA_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_BIAS, GL_POST_CONVOLUTION_BLUE_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionBlueBias = Gl.POST_CONVOLUTION_BLUE_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_BLUE_SCALE, GL_POST_CONVOLUTION_BLUE_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionBlueScale = Gl.POST_CONVOLUTION_BLUE_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_BIAS, GL_POST_CONVOLUTION_GREEN_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionGreenBias = Gl.POST_CONVOLUTION_GREEN_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_GREEN_SCALE, GL_POST_CONVOLUTION_GREEN_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionGreenScale = Gl.POST_CONVOLUTION_GREEN_SCALE,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_BIAS, GL_POST_CONVOLUTION_RED_BIAS_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionRedBias = Gl.POST_CONVOLUTION_RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_POST_CONVOLUTION_RED_SCALE, GL_POST_CONVOLUTION_RED_SCALE_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		PostConvolutionRedScale = Gl.POST_CONVOLUTION_RED_SCALE,

		/// <summary>
		/// Strongly typed for value GL_RED_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RedBias = Gl.RED_BIAS,

		/// <summary>
		/// Strongly typed for value GL_RED_SCALE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		RedScale = Gl.RED_SCALE,

	}

	/// <summary>
	/// Strongly typed enumeration PixelType.
	/// </summary>
	public enum PixelType
	{
		/// <summary>
		/// Strongly typed for value GL_BITMAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Bitmap = Gl.BITMAP,

		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE_3_3_2, GL_UNSIGNED_BYTE_3_3_2_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		UnsignedByte332 = Gl.UNSIGNED_BYTE_3_3_2,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_10_10_10_2, GL_UNSIGNED_INT_10_10_10_2_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		UnsignedInt1010102 = Gl.UNSIGNED_INT_10_10_10_2,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_8_8_8_8, GL_UNSIGNED_INT_8_8_8_8_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		UnsignedInt8888 = Gl.UNSIGNED_INT_8_8_8_8,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_4_4_4_4, GL_UNSIGNED_SHORT_4_4_4_4_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		UnsignedShort4444 = Gl.UNSIGNED_SHORT_4_4_4_4,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_5_5_1, GL_UNSIGNED_SHORT_5_5_5_1_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_packed_pixels")]
		UnsignedShort5551 = Gl.UNSIGNED_SHORT_5_5_5_1,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_HALF_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_half_float_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_half_float_pixel")]
		[RequiredByFeature("GL_NV_half_float")]
		HalfFloat = Gl.HALF_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE_2_3_3_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		UnsignedByte233Rev = Gl.UNSIGNED_BYTE_2_3_3_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_6_5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedShort565 = Gl.UNSIGNED_SHORT_5_6_5,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_1_5_5_5_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_read_format_bgra", Api = "gles1|gles2")]
		UnsignedShort1555Rev = Gl.UNSIGNED_SHORT_1_5_5_5_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT_5_6_5_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		UnsignedShort565Rev = Gl.UNSIGNED_SHORT_5_6_5_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_type_2_10_10_10_REV", Api = "gles2")]
		UnsignedInt2101010Rev = Gl.UNSIGNED_INT_2_10_10_10_REV,

	}

	/// <summary>
	/// Strongly typed enumeration PointParameterName.
	/// </summary>
	public enum PointParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_DISTANCE_ATTENUATION_EXT, GL_DISTANCE_ATTENUATION_SGIS, GL_POINT_DISTANCE_ATTENUATION, 
		/// GL_POINT_DISTANCE_ATTENUATION_ARB.
		/// </summary>
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		DistanceAttenuationExt = Gl.DISTANCE_ATTENUATION_EXT,

		/// <summary>
		/// Strongly typed for value GL_POINT_FADE_THRESHOLD_SIZE, GL_POINT_FADE_THRESHOLD_SIZE_ARB, 
		/// GL_POINT_FADE_THRESHOLD_SIZE_EXT, GL_POINT_FADE_THRESHOLD_SIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		PointFadeThresholdSize = Gl.POINT_FADE_THRESHOLD_SIZE,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MAX, GL_POINT_SIZE_MAX_ARB, GL_POINT_SIZE_MAX_EXT, GL_POINT_SIZE_MAX_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSizeMax = Gl.POINT_SIZE_MAX,

		/// <summary>
		/// Strongly typed for value GL_POINT_SIZE_MIN, GL_POINT_SIZE_MIN_ARB, GL_POINT_SIZE_MIN_EXT, GL_POINT_SIZE_MIN_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ARB_point_parameters")]
		[RequiredByFeature("GL_EXT_point_parameters")]
		[RequiredByFeature("GL_SGIS_point_parameters")]
		[RemovedByFeature("GL_VERSION_3_2")]
		PointSizeMin = Gl.POINT_SIZE_MIN,

	}

	/// <summary>
	/// Strongly typed enumeration PolygonMode.
	/// </summary>
	public enum PolygonMode
	{
		/// <summary>
		/// Strongly typed for value GL_FILL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Fill = Gl.FILL,

		/// <summary>
		/// Strongly typed for value GL_LINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Line = Gl.LINE,

		/// <summary>
		/// Strongly typed for value GL_POINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		Point = Gl.POINT,

	}

	/// <summary>
	/// Strongly typed enumeration PrecisionType.
	/// </summary>
	public enum PrecisionType
	{
		/// <summary>
		/// Strongly typed for value GL_HIGH_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		HighFloat = Gl.HIGH_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_HIGH_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		HighInt = Gl.HIGH_INT,

		/// <summary>
		/// Strongly typed for value GL_LOW_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		LowFloat = Gl.LOW_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_LOW_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		LowInt = Gl.LOW_INT,

		/// <summary>
		/// Strongly typed for value GL_MEDIUM_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		MediumFloat = Gl.MEDIUM_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_MEDIUM_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		MediumInt = Gl.MEDIUM_INT,

	}

	/// <summary>
	/// Strongly typed enumeration PrimitiveType.
	/// </summary>
	public enum PrimitiveType
	{
		/// <summary>
		/// Strongly typed for value GL_LINES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Lines = Gl.LINES,

		/// <summary>
		/// Strongly typed for value GL_LINES_ADJACENCY, GL_LINES_ADJACENCY_ARB, GL_LINES_ADJACENCY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		LinesAdjacency = Gl.LINES_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_LINE_LOOP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		LineLoop = Gl.LINE_LOOP,

		/// <summary>
		/// Strongly typed for value GL_LINE_STRIP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		LineStrip = Gl.LINE_STRIP,

		/// <summary>
		/// Strongly typed for value GL_LINE_STRIP_ADJACENCY, GL_LINE_STRIP_ADJACENCY_ARB, GL_LINE_STRIP_ADJACENCY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		LineStripAdjacency = Gl.LINE_STRIP_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_PATCHES, GL_PATCHES_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_gpu_shader5", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Patches = Gl.PATCHES,

		/// <summary>
		/// Strongly typed for value GL_POINTS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Points = Gl.POINTS,

		/// <summary>
		/// Strongly typed for value GL_POLYGON.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Polygon = Gl.POLYGON,

		/// <summary>
		/// Strongly typed for value GL_QUADS, GL_QUADS_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Quads = Gl.QUADS,

		/// <summary>
		/// Strongly typed for value GL_QUAD_STRIP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		QuadStrip = Gl.QUAD_STRIP,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Triangles = Gl.TRIANGLES,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLES_ADJACENCY, GL_TRIANGLES_ADJACENCY_ARB, GL_TRIANGLES_ADJACENCY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		TrianglesAdjacency = Gl.TRIANGLES_ADJACENCY,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_FAN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TriangleFan = Gl.TRIANGLE_FAN,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_STRIP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TriangleStrip = Gl.TRIANGLE_STRIP,

		/// <summary>
		/// Strongly typed for value GL_TRIANGLE_STRIP_ADJACENCY, GL_TRIANGLE_STRIP_ADJACENCY_ARB, GL_TRIANGLE_STRIP_ADJACENCY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_NV_geometry_program4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		TriangleStripAdjacency = Gl.TRIANGLE_STRIP_ADJACENCY,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramParameterPName.
	/// </summary>
	public enum ProgramParameterPName
	{
		/// <summary>
		/// Strongly typed for value GL_PROGRAM_BINARY_RETRIEVABLE_HINT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_get_program_binary", Api = "gl|glcore")]
		ProgramBinaryRetrievableHint = Gl.PROGRAM_BINARY_RETRIEVABLE_HINT,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_SEPARABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		ProgramSeparable = Gl.PROGRAM_SEPARABLE,

	}

	/// <summary>
	/// Strongly typed enumeration QueryObjectParameterName.
	/// </summary>
	public enum QueryObjectParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_QUERY_RESULT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		QueryResult = Gl.QUERY_RESULT,

		/// <summary>
		/// Strongly typed for value GL_QUERY_RESULT_AVAILABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		QueryResultAvailable = Gl.QUERY_RESULT_AVAILABLE,

		/// <summary>
		/// Strongly typed for value GL_QUERY_RESULT_NO_WAIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_query_buffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_AMD_query_buffer_object")]
		QueryResultNoWait = Gl.QUERY_RESULT_NO_WAIT,

		/// <summary>
		/// Strongly typed for value GL_QUERY_TARGET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ARB_direct_state_access", Api = "gl|glcore")]
		QueryTarget = Gl.QUERY_TARGET,

	}

	/// <summary>
	/// Strongly typed enumeration QueryParameterName.
	/// </summary>
	public enum QueryParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_CURRENT_QUERY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		CurrentQuery = Gl.CURRENT_QUERY,

		/// <summary>
		/// Strongly typed for value GL_QUERY_COUNTER_BITS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		QueryCounterBits = Gl.QUERY_COUNTER_BITS,

	}

	/// <summary>
	/// Strongly typed enumeration QueryTarget.
	/// </summary>
	public enum QueryTarget
	{
		/// <summary>
		/// Strongly typed for value GL_ANY_SAMPLES_PASSED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_occlusion_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		AnySamplesPassed = Gl.ANY_SAMPLES_PASSED,

		/// <summary>
		/// Strongly typed for value GL_ANY_SAMPLES_PASSED_CONSERVATIVE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_occlusion_query_boolean", Api = "gles2")]
		AnySamplesPassedConservative = Gl.ANY_SAMPLES_PASSED_CONSERVATIVE,

		/// <summary>
		/// Strongly typed for value GL_PRIMITIVES_GENERATED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		PrimitivesGenerated = Gl.PRIMITIVES_GENERATED,

		/// <summary>
		/// Strongly typed for value GL_SAMPLES_PASSED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_occlusion_query")]
		SamplesPassed = Gl.SAMPLES_PASSED,

		/// <summary>
		/// Strongly typed for value GL_TIME_ELAPSED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_timer_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_disjoint_timer_query", Api = "gles2")]
		[RequiredByFeature("GL_EXT_timer_query")]
		TimeElapsed = Gl.TIME_ELAPSED,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackPrimitivesWritten = Gl.TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN,

	}

	/// <summary>
	/// Strongly typed enumeration ObjectIdentifier.
	/// </summary>
	public enum ObjectIdentifier
	{
		/// <summary>
		/// Strongly typed for value GL_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		Buffer = Gl.BUFFER,

		/// <summary>
		/// Strongly typed for value GL_FRAMEBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		Framebuffer = Gl.FRAMEBUFFER,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		Program = Gl.PROGRAM,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_PIPELINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		ProgramPipeline = Gl.PROGRAM_PIPELINE,

		/// <summary>
		/// Strongly typed for value GL_QUERY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		Query = Gl.QUERY,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		Renderbuffer = Gl.RENDERBUFFER,

		/// <summary>
		/// Strongly typed for value GL_SAMPLER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		Sampler = Gl.SAMPLER,

		/// <summary>
		/// Strongly typed for value GL_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		Shader = Gl.SHADER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Texture = Gl.TEXTURE,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_transform_feedback2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		TransformFeedback = Gl.TRANSFORM_FEEDBACK,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_vertex_array")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		VertexArray = Gl.VERTEX_ARRAY,

	}

	/// <summary>
	/// Strongly typed enumeration OcclusionQueryEventMaskAMD.
	/// </summary>
	[Flags()]
	public enum OcclusionQueryEventMaskAMD : uint
	{
		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_PASS_EVENT_BIT_AMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		QueryDepthPassEventBitAmd = Gl.QUERY_DEPTH_PASS_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_FAIL_EVENT_BIT_AMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		QueryDepthFailEventBitAmd = Gl.QUERY_DEPTH_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_STENCIL_FAIL_EVENT_BIT_AMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		QueryStencilFailEventBitAmd = Gl.QUERY_STENCIL_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		QueryDepthBoundsFailEventBitAmd = Gl.QUERY_DEPTH_BOUNDS_FAIL_EVENT_BIT_AMD,

		/// <summary>
		/// Strongly typed for value GL_QUERY_ALL_EVENT_BITS_AMD.
		/// </summary>
		[RequiredByFeature("GL_AMD_occlusion_query_event")]
		QueryAllEventBitsAmd = Gl.QUERY_ALL_EVENT_BITS_AMD,

	}

	/// <summary>
	/// Strongly typed enumeration PackedVertexType.
	/// </summary>
	public enum PackedVertexType
	{
		/// <summary>
		/// Strongly typed for value GL_INT_2_10_10_10_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		Int2101010Rev = Gl.INT_2_10_10_10_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_type_2_10_10_10_REV", Api = "gles2")]
		UnsignedInt2101010Rev = Gl.UNSIGNED_INT_2_10_10_10_REV,

	}

	/// <summary>
	/// Strongly typed enumeration PipelineParameterName.
	/// </summary>
	public enum PipelineParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_ACTIVE_PROGRAM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		ActiveProgram = Gl.ACTIVE_PROGRAM,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		FragmentShader = Gl.FRAGMENT_SHADER,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		GeometryShader = Gl.GEOMETRY_SHADER,

		/// <summary>
		/// Strongly typed for value GL_INFO_LOG_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		InfoLogLength = Gl.INFO_LOG_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessControlShader = Gl.TESS_CONTROL_SHADER,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessEvaluationShader = Gl.TESS_EVALUATION_SHADER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexShader = Gl.VERTEX_SHADER,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramInterface.
	/// </summary>
	public enum ProgramInterface
	{
		/// <summary>
		/// Strongly typed for value GL_BUFFER_VARIABLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		BufferVariable = Gl.BUFFER_VARIABLE,

		/// <summary>
		/// Strongly typed for value GL_COMPUTE_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ComputeSubroutine = Gl.COMPUTE_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_COMPUTE_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ComputeSubroutineUniform = Gl.COMPUTE_SUBROUTINE_UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		FragmentSubroutine = Gl.FRAGMENT_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		FragmentSubroutineUniform = Gl.FRAGMENT_SUBROUTINE_UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		GeometrySubroutine = Gl.GEOMETRY_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		GeometrySubroutineUniform = Gl.GEOMETRY_SUBROUTINE_UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_INPUT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ProgramInput = Gl.PROGRAM_INPUT,

		/// <summary>
		/// Strongly typed for value GL_PROGRAM_OUTPUT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ProgramOutput = Gl.PROGRAM_OUTPUT,

		/// <summary>
		/// Strongly typed for value GL_SHADER_STORAGE_BLOCK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ShaderStorageBlock = Gl.SHADER_STORAGE_BLOCK,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		TessControlSubroutine = Gl.TESS_CONTROL_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		TessControlSubroutineUniform = Gl.TESS_CONTROL_SUBROUTINE_UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		TessEvaluationSubroutine = Gl.TESS_EVALUATION_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		TessEvaluationSubroutineUniform = Gl.TESS_EVALUATION_SUBROUTINE_UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_enhanced_layouts", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackBuffer = Gl.TRANSFORM_FEEDBACK_BUFFER,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_VARYING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		TransformFeedbackVarying = Gl.TRANSFORM_FEEDBACK_VARYING,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		Uniform = Gl.UNIFORM,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		UniformBlock = Gl.UNIFORM_BLOCK,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_SUBROUTINE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		VertexSubroutine = Gl.VERTEX_SUBROUTINE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_SUBROUTINE_UNIFORM.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		VertexSubroutineUniform = Gl.VERTEX_SUBROUTINE_UNIFORM,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramInterfacePName.
	/// </summary>
	public enum ProgramInterfacePName
	{
		/// <summary>
		/// Strongly typed for value GL_ACTIVE_RESOURCES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		ActiveResources = Gl.ACTIVE_RESOURCES,

		/// <summary>
		/// Strongly typed for value GL_MAX_NAME_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		MaxNameLength = Gl.MAX_NAME_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_MAX_NUM_ACTIVE_VARIABLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		MaxNumActiveVariables = Gl.MAX_NUM_ACTIVE_VARIABLES,

		/// <summary>
		/// Strongly typed for value GL_MAX_NUM_COMPATIBLE_SUBROUTINES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		MaxNumCompatibleSubroutines = Gl.MAX_NUM_COMPATIBLE_SUBROUTINES,

	}

	/// <summary>
	/// Strongly typed enumeration ProgramStagePName.
	/// </summary>
	public enum ProgramStagePName
	{
		/// <summary>
		/// Strongly typed for value GL_ACTIVE_SUBROUTINES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		ActiveSubroutines = Gl.ACTIVE_SUBROUTINES,

		/// <summary>
		/// Strongly typed for value GL_ACTIVE_SUBROUTINE_MAX_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		ActiveSubroutineMaxLength = Gl.ACTIVE_SUBROUTINE_MAX_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_ACTIVE_SUBROUTINE_UNIFORMS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		ActiveSubroutineUniforms = Gl.ACTIVE_SUBROUTINE_UNIFORMS,

		/// <summary>
		/// Strongly typed for value GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		ActiveSubroutineUniformLocations = Gl.ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS,

		/// <summary>
		/// Strongly typed for value GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		ActiveSubroutineUniformMaxLength = Gl.ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH,

	}

	/// <summary>
	/// Strongly typed enumeration ReadBufferMode.
	/// </summary>
	public enum ReadBufferMode
	{
		/// <summary>
		/// Strongly typed for value GL_AUX0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux0 = Gl.AUX0,

		/// <summary>
		/// Strongly typed for value GL_AUX1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux1 = Gl.AUX1,

		/// <summary>
		/// Strongly typed for value GL_AUX2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux2 = Gl.AUX2,

		/// <summary>
		/// Strongly typed for value GL_AUX3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Aux3 = Gl.AUX3,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_BACK_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackLeft = Gl.BACK_LEFT,

		/// <summary>
		/// Strongly typed for value GL_BACK_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		BackRight = Gl.BACK_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontLeft = Gl.FRONT_LEFT,

		/// <summary>
		/// Strongly typed for value GL_FRONT_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		FrontRight = Gl.FRONT_RIGHT,

		/// <summary>
		/// Strongly typed for value GL_LEFT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Left = Gl.LEFT,

		/// <summary>
		/// Strongly typed for value GL_RIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		Right = Gl.RIGHT,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		ColorAttachment0 = Gl.COLOR_ATTACHMENT0,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment1 = Gl.COLOR_ATTACHMENT1,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment2 = Gl.COLOR_ATTACHMENT2,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment3 = Gl.COLOR_ATTACHMENT3,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment4 = Gl.COLOR_ATTACHMENT4,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment5 = Gl.COLOR_ATTACHMENT5,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment6 = Gl.COLOR_ATTACHMENT6,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment7 = Gl.COLOR_ATTACHMENT7,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment8 = Gl.COLOR_ATTACHMENT8,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT9.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment9 = Gl.COLOR_ATTACHMENT9,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT10.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment10 = Gl.COLOR_ATTACHMENT10,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT11.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment11 = Gl.COLOR_ATTACHMENT11,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment12 = Gl.COLOR_ATTACHMENT12,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT13.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment13 = Gl.COLOR_ATTACHMENT13,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT14.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment14 = Gl.COLOR_ATTACHMENT14,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT15.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_NV_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_fbo_color_attachments", Api = "gles2")]
		ColorAttachment15 = Gl.COLOR_ATTACHMENT15,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment16 = Gl.COLOR_ATTACHMENT16,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT17.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment17 = Gl.COLOR_ATTACHMENT17,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT18.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment18 = Gl.COLOR_ATTACHMENT18,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT19.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment19 = Gl.COLOR_ATTACHMENT19,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT20.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment20 = Gl.COLOR_ATTACHMENT20,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT21.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment21 = Gl.COLOR_ATTACHMENT21,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT22.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment22 = Gl.COLOR_ATTACHMENT22,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT23.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment23 = Gl.COLOR_ATTACHMENT23,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT24.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment24 = Gl.COLOR_ATTACHMENT24,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT25.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment25 = Gl.COLOR_ATTACHMENT25,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT26.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment26 = Gl.COLOR_ATTACHMENT26,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT27.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment27 = Gl.COLOR_ATTACHMENT27,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT28.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment28 = Gl.COLOR_ATTACHMENT28,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT29.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment29 = Gl.COLOR_ATTACHMENT29,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT30.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment30 = Gl.COLOR_ATTACHMENT30,

		/// <summary>
		/// Strongly typed for value GL_COLOR_ATTACHMENT31.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		ColorAttachment31 = Gl.COLOR_ATTACHMENT31,

	}

	/// <summary>
	/// Strongly typed enumeration RenderbufferParameterName.
	/// </summary>
	public enum RenderbufferParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferAlphaSize = Gl.RENDERBUFFER_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferBlueSize = Gl.RENDERBUFFER_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_DEPTH_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferDepthSize = Gl.RENDERBUFFER_DEPTH_SIZE,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferGreenSize = Gl.RENDERBUFFER_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferHeight = Gl.RENDERBUFFER_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_INTERNAL_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferInternalFormat = Gl.RENDERBUFFER_INTERNAL_FORMAT,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferWidth = Gl.RENDERBUFFER_WIDTH,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferRedSize = Gl.RENDERBUFFER_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_SAMPLES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ANGLE_framebuffer_multisample", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_framebuffer_multisample", Api = "gles1|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_multisample")]
		[RequiredByFeature("GL_EXT_multisampled_render_to_texture", Api = "gles1|gles2")]
		[RequiredByFeature("GL_NV_framebuffer_multisample", Api = "gles2")]
		RenderbufferSamples = Gl.RENDERBUFFER_SAMPLES,

		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER_STENCIL_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		RenderbufferStencilSize = Gl.RENDERBUFFER_STENCIL_SIZE,

	}

	/// <summary>
	/// Strongly typed enumeration RenderbufferTarget.
	/// </summary>
	public enum RenderbufferTarget
	{
		/// <summary>
		/// Strongly typed for value GL_RENDERBUFFER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_framebuffer_object", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_EXT_framebuffer_object")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		Renderbuffer = Gl.RENDERBUFFER,

	}

	/// <summary>
	/// Strongly typed enumeration RenderingMode.
	/// </summary>
	public enum RenderingMode
	{
		/// <summary>
		/// Strongly typed for value GL_FEEDBACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Feedback = Gl.FEEDBACK,

		/// <summary>
		/// Strongly typed for value GL_RENDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Render = Gl.RENDER,

		/// <summary>
		/// Strongly typed for value GL_SELECT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Select = Gl.SELECT,

	}

	/// <summary>
	/// Strongly typed enumeration SamplePatternSGIS.
	/// </summary>
	public enum SamplePatternSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_1PASS_EXT, GL_1PASS_SGIS.
		/// </summary>
		_1passExt = Gl._1PASS_EXT,

		/// <summary>
		/// Strongly typed for value GL_2PASS_0_EXT, GL_2PASS_0_SGIS.
		/// </summary>
		_2pass0Ext = Gl._2PASS_0_EXT,

		/// <summary>
		/// Strongly typed for value GL_2PASS_1_EXT, GL_2PASS_1_SGIS.
		/// </summary>
		_2pass1Ext = Gl._2PASS_1_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_0_EXT, GL_4PASS_0_SGIS.
		/// </summary>
		_4pass0Ext = Gl._4PASS_0_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_1_EXT, GL_4PASS_1_SGIS.
		/// </summary>
		_4pass1Ext = Gl._4PASS_1_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_2_EXT, GL_4PASS_2_SGIS.
		/// </summary>
		_4pass2Ext = Gl._4PASS_2_EXT,

		/// <summary>
		/// Strongly typed for value GL_4PASS_3_EXT, GL_4PASS_3_SGIS.
		/// </summary>
		_4pass3Ext = Gl._4PASS_3_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration SamplerParameterName.
	/// </summary>
	public enum SamplerParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		TextureBorderColor = Gl.TEXTURE_BORDER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		TextureCompareMode = Gl.TEXTURE_COMPARE_MODE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_FUNC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		TextureCompareFunc = Gl.TEXTURE_COMPARE_FUNC,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAG_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMagFilter = Gl.TEXTURE_MAG_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LOD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMaxLod = Gl.TEXTURE_MAX_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMinFilter = Gl.TEXTURE_MIN_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_LOD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMinLod = Gl.TEXTURE_MIN_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		TextureWrapR = Gl.TEXTURE_WRAP_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapS = Gl.TEXTURE_WRAP_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapT = Gl.TEXTURE_WRAP_T,

	}

	/// <summary>
	/// Strongly typed enumeration SemaphoreParameterName.
	/// </summary>
	public enum SemaphoreParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_D3D12_FENCE_VALUE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore_win32", Api = "gl|gles2")]
		D3d12FenceValueExt = Gl.D3D12_FENCE_VALUE_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration SeparableTarget.
	/// </summary>
	public enum SeparableTarget
	{
		/// <summary>
		/// Strongly typed for value GL_SEPARABLE_2D, GL_SEPARABLE_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_ARB_imaging", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_convolution")]
		Separable2d = Gl.SEPARABLE_2D,

	}

	/// <summary>
	/// Strongly typed enumeration ShaderType.
	/// </summary>
	public enum ShaderType
	{
		/// <summary>
		/// Strongly typed for value GL_COMPUTE_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		ComputeShader = Gl.COMPUTE_SHADER,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_fragment_shader")]
		FragmentShader = Gl.FRAGMENT_SHADER,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_geometry_shader4", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_geometry_shader4")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		GeometryShader = Gl.GEOMETRY_SHADER,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessControlShader = Gl.TESS_CONTROL_SHADER,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessEvaluationShader = Gl.TESS_EVALUATION_SHADER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexShader = Gl.VERTEX_SHADER,

	}

	/// <summary>
	/// Strongly typed enumeration ShaderParameterName.
	/// </summary>
	public enum ShaderParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_COMPILE_STATUS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		CompileStatus = Gl.COMPILE_STATUS,

		/// <summary>
		/// Strongly typed for value GL_DELETE_STATUS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		DeleteStatus = Gl.DELETE_STATUS,

		/// <summary>
		/// Strongly typed for value GL_INFO_LOG_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		InfoLogLength = Gl.INFO_LOG_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_SHADER_SOURCE_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		ShaderSourceLength = Gl.SHADER_SOURCE_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_SHADER_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		ShaderType = Gl.SHADER_TYPE,

	}

	/// <summary>
	/// Strongly typed enumeration ShadingModel.
	/// </summary>
	public enum ShadingModel
	{
		/// <summary>
		/// Strongly typed for value GL_FLAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Flat = Gl.FLAT,

		/// <summary>
		/// Strongly typed for value GL_SMOOTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Smooth = Gl.SMOOTH,

	}

	/// <summary>
	/// Strongly typed enumeration StencilFaceDirection.
	/// </summary>
	public enum StencilFaceDirection
	{
		/// <summary>
		/// Strongly typed for value GL_FRONT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Front = Gl.FRONT,

		/// <summary>
		/// Strongly typed for value GL_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		Back = Gl.BACK,

		/// <summary>
		/// Strongly typed for value GL_FRONT_AND_BACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		FrontAndBack = Gl.FRONT_AND_BACK,

	}

	/// <summary>
	/// Strongly typed enumeration StencilFunction.
	/// </summary>
	public enum StencilFunction
	{
		/// <summary>
		/// Strongly typed for value GL_ALWAYS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Always = Gl.ALWAYS,

		/// <summary>
		/// Strongly typed for value GL_EQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		Equal = Gl.EQUAL,

		/// <summary>
		/// Strongly typed for value GL_GEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Gequal = Gl.GEQUAL,

		/// <summary>
		/// Strongly typed for value GL_GREATER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Greater = Gl.GREATER,

		/// <summary>
		/// Strongly typed for value GL_LEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Lequal = Gl.LEQUAL,

		/// <summary>
		/// Strongly typed for value GL_LESS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Less = Gl.LESS,

		/// <summary>
		/// Strongly typed for value GL_NEVER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Never = Gl.NEVER,

		/// <summary>
		/// Strongly typed for value GL_NOTEQUAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Notequal = Gl.NOTEQUAL,

	}

	/// <summary>
	/// Strongly typed enumeration StencilOp.
	/// </summary>
	public enum StencilOp
	{
		/// <summary>
		/// Strongly typed for value GL_DECR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Decr = Gl.DECR,

		/// <summary>
		/// Strongly typed for value GL_INCR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Incr = Gl.INCR,

		/// <summary>
		/// Strongly typed for value GL_INVERT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		Invert = Gl.INVERT,

		/// <summary>
		/// Strongly typed for value GL_KEEP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Keep = Gl.KEEP,

		/// <summary>
		/// Strongly typed for value GL_REPLACE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Replace = Gl.REPLACE,

		/// <summary>
		/// Strongly typed for value GL_ZERO.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		Zero = Gl.ZERO,

	}

	/// <summary>
	/// Strongly typed enumeration StringName.
	/// </summary>
	public enum StringName
	{
		/// <summary>
		/// Strongly typed for value GL_EXTENSIONS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Extensions = Gl.EXTENSIONS,

		/// <summary>
		/// Strongly typed for value GL_RENDERER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Renderer = Gl.RENDERER,

		/// <summary>
		/// Strongly typed for value GL_VENDOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Vendor = Gl.VENDOR,

		/// <summary>
		/// Strongly typed for value GL_VERSION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Version = Gl.VERSION,

		/// <summary>
		/// Strongly typed for value GL_SHADING_LANGUAGE_VERSION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_shading_language_100")]
		ShadingLanguageVersion = Gl.SHADING_LANGUAGE_VERSION,

	}

	/// <summary>
	/// Strongly typed enumeration SubroutineParameterName.
	/// </summary>
	public enum SubroutineParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_COMPATIBLE_SUBROUTINES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		CompatibleSubroutines = Gl.COMPATIBLE_SUBROUTINES,

		/// <summary>
		/// Strongly typed for value GL_NUM_COMPATIBLE_SUBROUTINES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_program_interface_query", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		NumCompatibleSubroutines = Gl.NUM_COMPATIBLE_SUBROUTINES,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_NAME_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformNameLength = Gl.UNIFORM_NAME_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformSize = Gl.UNIFORM_SIZE,

	}

	/// <summary>
	/// Strongly typed enumeration SyncParameterName.
	/// </summary>
	public enum SyncParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_OBJECT_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		ObjectType = Gl.OBJECT_TYPE,

		/// <summary>
		/// Strongly typed for value GL_SYNC_STATUS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		SyncStatus = Gl.SYNC_STATUS,

		/// <summary>
		/// Strongly typed for value GL_SYNC_CONDITION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		SyncCondition = Gl.SYNC_CONDITION,

		/// <summary>
		/// Strongly typed for value GL_SYNC_FLAGS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		SyncFlags = Gl.SYNC_FLAGS,

	}

	/// <summary>
	/// Strongly typed enumeration SyncStatus.
	/// </summary>
	public enum SyncStatus
	{
		/// <summary>
		/// Strongly typed for value GL_ALREADY_SIGNALED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		AlreadySignaled = Gl.ALREADY_SIGNALED,

		/// <summary>
		/// Strongly typed for value GL_CONDITION_SATISFIED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		ConditionSatisfied = Gl.CONDITION_SATISFIED,

		/// <summary>
		/// Strongly typed for value GL_TIMEOUT_EXPIRED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		TimeoutExpired = Gl.TIMEOUT_EXPIRED,

		/// <summary>
		/// Strongly typed for value GL_WAIT_FAILED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_sync", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_sync", Api = "gles1|gles2")]
		WaitFailed = Gl.WAIT_FAILED,

	}

	/// <summary>
	/// Strongly typed enumeration TexCoordPointerType.
	/// </summary>
	public enum TexCoordPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

	}

	/// <summary>
	/// Strongly typed enumeration TextureCoordName.
	/// </summary>
	public enum TextureCoordName
	{
		/// <summary>
		/// Strongly typed for value GL_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		S = Gl.S,

		/// <summary>
		/// Strongly typed for value GL_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		T = Gl.T,

		/// <summary>
		/// Strongly typed for value GL_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		R = Gl.R,

		/// <summary>
		/// Strongly typed for value GL_Q.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Q = Gl.Q,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvMode.
	/// </summary>
	public enum TextureEnvMode
	{
		/// <summary>
		/// Strongly typed for value GL_ADD.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Add = Gl.ADD,

		/// <summary>
		/// Strongly typed for value GL_BLEND.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		Blend = Gl.BLEND,

		/// <summary>
		/// Strongly typed for value GL_DECAL.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Decal = Gl.DECAL,

		/// <summary>
		/// Strongly typed for value GL_MODULATE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Modulate = Gl.MODULATE,

		/// <summary>
		/// Strongly typed for value GL_REPLACE_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_texture")]
		ReplaceExt = Gl.REPLACE_EXT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_BIAS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_add_env")]
		TextureEnvBiasSgix = Gl.TEXTURE_ENV_BIAS_SGIX,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvParameter.
	/// </summary>
	public enum TextureEnvParameter
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_COLOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureEnvColor = Gl.TEXTURE_ENV_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureEnvMode = Gl.TEXTURE_ENV_MODE,

	}

	/// <summary>
	/// Strongly typed enumeration TextureEnvTarget.
	/// </summary>
	public enum TextureEnvTarget
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ENV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureEnv = Gl.TEXTURE_ENV,

	}

	/// <summary>
	/// Strongly typed enumeration TextureFilterFuncSGIS.
	/// </summary>
	public enum TextureFilterFuncSGIS
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		Filter4Sgis = Gl.FILTER4_SGIS,

	}

	/// <summary>
	/// Strongly typed enumeration TextureGenMode.
	/// </summary>
	public enum TextureGenMode
	{
		/// <summary>
		/// Strongly typed for value GL_EYE_DISTANCE_TO_LINE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		EyeDistanceToLineSgis = Gl.EYE_DISTANCE_TO_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_DISTANCE_TO_POINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		EyeDistanceToPointSgis = Gl.EYE_DISTANCE_TO_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EyeLinear = Gl.EYE_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_DISTANCE_TO_LINE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		ObjectDistanceToLineSgis = Gl.OBJECT_DISTANCE_TO_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_DISTANCE_TO_POINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		ObjectDistanceToPointSgis = Gl.OBJECT_DISTANCE_TO_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ObjectLinear = Gl.OBJECT_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_SPHERE_MAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		SphereMap = Gl.SPHERE_MAP,

	}

	/// <summary>
	/// Strongly typed enumeration TextureGenParameter.
	/// </summary>
	public enum TextureGenParameter
	{
		/// <summary>
		/// Strongly typed for value GL_EYE_LINE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		EyeLineSgis = Gl.EYE_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_EYE_PLANE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_fog_distance")]
		[RemovedByFeature("GL_VERSION_3_2")]
		EyePlane = Gl.EYE_PLANE,

		/// <summary>
		/// Strongly typed for value GL_EYE_POINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		EyePointSgis = Gl.EYE_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_LINE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		ObjectLineSgis = Gl.OBJECT_LINE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_PLANE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		ObjectPlane = Gl.OBJECT_PLANE,

		/// <summary>
		/// Strongly typed for value GL_OBJECT_POINT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_point_line_texgen")]
		ObjectPointSgis = Gl.OBJECT_POINT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEN_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureGenMode = Gl.TEXTURE_GEN_MODE,

	}

	/// <summary>
	/// Strongly typed enumeration TextureLayout.
	/// </summary>
	public enum TextureLayout
	{
		/// <summary>
		/// Strongly typed for value GL_LAYOUT_GENERAL_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutGeneralExt = Gl.LAYOUT_GENERAL_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_COLOR_ATTACHMENT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutColorAttachmentExt = Gl.LAYOUT_COLOR_ATTACHMENT_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutDepthStencilAttachmentExt = Gl.LAYOUT_DEPTH_STENCIL_ATTACHMENT_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutDepthStencilReadOnlyExt = Gl.LAYOUT_DEPTH_STENCIL_READ_ONLY_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_SHADER_READ_ONLY_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutShaderReadOnlyExt = Gl.LAYOUT_SHADER_READ_ONLY_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_TRANSFER_SRC_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutTransferSrcExt = Gl.LAYOUT_TRANSFER_SRC_EXT,

		/// <summary>
		/// Strongly typed for value GL_LAYOUT_TRANSFER_DST_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_semaphore", Api = "gl|gles2")]
		LayoutTransferDstExt = Gl.LAYOUT_TRANSFER_DST_EXT,

	}

	/// <summary>
	/// Strongly typed enumeration TextureMagFilter.
	/// </summary>
	public enum TextureMagFilter
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		Filter4Sgis = Gl.FILTER4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Linear = Gl.LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_ALPHA_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		LinearDetailAlphaSgis = Gl.LINEAR_DETAIL_ALPHA_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_COLOR_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		LinearDetailColorSgis = Gl.LINEAR_DETAIL_COLOR_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_DETAIL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		LinearDetailSgis = Gl.LINEAR_DETAIL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_ALPHA_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		LinearSharpenAlphaSgis = Gl.LINEAR_SHARPEN_ALPHA_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_COLOR_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		LinearSharpenColorSgis = Gl.LINEAR_SHARPEN_COLOR_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_SHARPEN_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		LinearSharpenSgis = Gl.LINEAR_SHARPEN_SGIS,

		/// <summary>
		/// Strongly typed for value GL_NEAREST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Nearest = Gl.NEAREST,

	}

	/// <summary>
	/// Strongly typed enumeration TextureMinFilter.
	/// </summary>
	public enum TextureMinFilter
	{
		/// <summary>
		/// Strongly typed for value GL_FILTER4_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		Filter4Sgis = Gl.FILTER4_SGIS,

		/// <summary>
		/// Strongly typed for value GL_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Linear = Gl.LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_CLIPMAP_LINEAR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		LinearClipmapLinearSgix = Gl.LINEAR_CLIPMAP_LINEAR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_CLIPMAP_NEAREST_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		LinearClipmapNearestSgix = Gl.LINEAR_CLIPMAP_NEAREST_SGIX,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_MIPMAP_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		LinearMipmapLinear = Gl.LINEAR_MIPMAP_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_LINEAR_MIPMAP_NEAREST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		LinearMipmapNearest = Gl.LINEAR_MIPMAP_NEAREST,

		/// <summary>
		/// Strongly typed for value GL_NEAREST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Nearest = Gl.NEAREST,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_CLIPMAP_LINEAR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		NearestClipmapLinearSgix = Gl.NEAREST_CLIPMAP_LINEAR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_CLIPMAP_NEAREST_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		NearestClipmapNearestSgix = Gl.NEAREST_CLIPMAP_NEAREST_SGIX,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_MIPMAP_LINEAR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		NearestMipmapLinear = Gl.NEAREST_MIPMAP_LINEAR,

		/// <summary>
		/// Strongly typed for value GL_NEAREST_MIPMAP_NEAREST.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		NearestMipmapNearest = Gl.NEAREST_MIPMAP_NEAREST,

	}

	/// <summary>
	/// Strongly typed enumeration TextureParameterName.
	/// </summary>
	public enum TextureParameterName
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureLevelSgis = Gl.DETAIL_TEXTURE_LEVEL_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_MODE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureModeSgis = Gl.DETAIL_TEXTURE_MODE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_DUAL_TEXTURE_SELECT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		DualTextureSelectSgis = Gl.DUAL_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_GENERATE_MIPMAP, GL_GENERATE_MIPMAP_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_SGIS_generate_mipmap")]
		[RemovedByFeature("GL_VERSION_3_2")]
		GenerateMipmap = Gl.GENERATE_MIPMAP,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_BIAS_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterBiasSgix = Gl.POST_TEXTURE_FILTER_BIAS_SGIX,

		/// <summary>
		/// Strongly typed for value GL_POST_TEXTURE_FILTER_SCALE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_scale_bias")]
		PostTextureFilterScaleSgix = Gl.POST_TEXTURE_FILTER_SCALE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_QUAD_TEXTURE_SELECT_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_select")]
		QuadTextureSelectSgis = Gl.QUAD_TEXTURE_SELECT_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SHADOW_AMBIENT_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow_ambient")]
		ShadowAmbientSgix = Gl.SHADOW_AMBIENT_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER_COLOR, GL_TEXTURE_BORDER_COLOR_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		TextureBorderColor = Gl.TEXTURE_BORDER_COLOR,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_CENTER_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapCenterSgix = Gl.TEXTURE_CLIPMAP_CENTER_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapDepthSgix = Gl.TEXTURE_CLIPMAP_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_FRAME_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapFrameSgix = Gl.TEXTURE_CLIPMAP_FRAME_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_LOD_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapLodOffsetSgix = Gl.TEXTURE_CLIPMAP_LOD_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_OFFSET_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapOffsetSgix = Gl.TEXTURE_CLIPMAP_OFFSET_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_clipmap")]
		TextureClipmapVirtualDepthSgix = Gl.TEXTURE_CLIPMAP_VIRTUAL_DEPTH_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureCompareSgix = Gl.TEXTURE_COMPARE_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasRSgix = Gl.TEXTURE_LOD_BIAS_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_S_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasSSgix = Gl.TEXTURE_LOD_BIAS_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS_T_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_lod_bias")]
		TextureLodBiasTSgix = Gl.TEXTURE_LOD_BIAS_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAG_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMagFilter = Gl.TEXTURE_MAG_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampRSgix = Gl.TEXTURE_MAX_CLAMP_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_S_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampSSgix = Gl.TEXTURE_MAX_CLAMP_S_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_CLAMP_T_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_texture_coordinate_clamp")]
		TextureMaxClampTSgix = Gl.TEXTURE_MAX_CLAMP_T_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_FILTER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureMinFilter = Gl.TEXTURE_MIN_FILTER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_PRIORITY, GL_TEXTURE_PRIORITY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TexturePriority = Gl.TEXTURE_PRIORITY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_Q_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		TextureWrapQSgis = Gl.TEXTURE_WRAP_Q_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_R, GL_TEXTURE_WRAP_R_EXT, GL_TEXTURE_WRAP_R_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		TextureWrapR = Gl.TEXTURE_WRAP_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_S.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapS = Gl.TEXTURE_WRAP_S,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WRAP_T.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		TextureWrapT = Gl.TEXTURE_WRAP_T,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BASE_LEVEL, GL_TEXTURE_BASE_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureBaseLevel = Gl.TEXTURE_BASE_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		TextureCompareMode = Gl.TEXTURE_COMPARE_MODE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_FUNC.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shadow")]
		[RequiredByFeature("GL_EXT_shadow_samplers", Api = "gles2")]
		TextureCompareFunc = Gl.TEXTURE_COMPARE_FUNC,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LOD_BIAS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_4")]
		[RequiredByFeature("GL_EXT_texture_lod_bias", Api = "gl|gles1")]
		TextureLodBias = Gl.TEXTURE_LOD_BIAS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MIN_LOD, GL_TEXTURE_MIN_LOD_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMinLod = Gl.TEXTURE_MIN_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LOD, GL_TEXTURE_MAX_LOD_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMaxLod = Gl.TEXTURE_MAX_LOD,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_MAX_LEVEL, GL_TEXTURE_MAX_LEVEL_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_APPLE_texture_max_level", Api = "gles1|gles2")]
		[RequiredByFeature("GL_SGIS_texture_lod")]
		TextureMaxLevel = Gl.TEXTURE_MAX_LEVEL,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SWIZZLE_R.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		TextureSwizzleR = Gl.TEXTURE_SWIZZLE_R,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SWIZZLE_G.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		TextureSwizzleG = Gl.TEXTURE_SWIZZLE_G,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SWIZZLE_B.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		TextureSwizzleB = Gl.TEXTURE_SWIZZLE_B,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SWIZZLE_A.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		TextureSwizzleA = Gl.TEXTURE_SWIZZLE_A,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_SWIZZLE_RGBA.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ARB_texture_swizzle", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_swizzle")]
		TextureSwizzleRgba = Gl.TEXTURE_SWIZZLE_RGBA,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_TILING_EXT.
		/// </summary>
		[RequiredByFeature("GL_EXT_memory_object", Api = "gl|gles2")]
		TextureTilingExt = Gl.TEXTURE_TILING_EXT,

		/// <summary>
		/// Strongly typed for value GL_DEPTH_STENCIL_TEXTURE_MODE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_stencil_texturing", Api = "gl|glcore")]
		DepthStencilTextureMode = Gl.DEPTH_STENCIL_TEXTURE_MODE,

		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTextureFuncPointsSgis = Gl.DETAIL_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_SHARPEN_TEXTURE_FUNC_POINTS_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_sharpen_texture")]
		SharpenTextureFuncPointsSgis = Gl.SHARPEN_TEXTURE_FUNC_POINTS_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4DSIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dsizeSgis = Gl.TEXTURE_4DSIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_ALPHA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureAlphaSize = Gl.TEXTURE_ALPHA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BLUE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureBlueSize = Gl.TEXTURE_BLUE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_BORDER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureBorder = Gl.TEXTURE_BORDER,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPARE_OPERATOR_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureCompareOperatorSgix = Gl.TEXTURE_COMPARE_OPERATOR_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_COMPONENTS, GL_TEXTURE_INTERNAL_FORMAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureComponents = Gl.TEXTURE_COMPONENTS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_DEPTH_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		TextureDepth = Gl.TEXTURE_DEPTH,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_FILTER4_SIZE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture_filter4")]
		TextureFilter4SizeSgis = Gl.TEXTURE_FILTER4_SIZE_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GEQUAL_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureGequalRSgix = Gl.TEXTURE_GEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_GREEN_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureGreenSize = Gl.TEXTURE_GREEN_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_HEIGHT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		TextureHeight = Gl.TEXTURE_HEIGHT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_INTENSITY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureIntensitySize = Gl.TEXTURE_INTENSITY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LEQUAL_R_SGIX.
		/// </summary>
		[RequiredByFeature("GL_SGIX_shadow")]
		TextureLequalRSgix = Gl.TEXTURE_LEQUAL_R_SGIX,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_LUMINANCE_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureLuminanceSize = Gl.TEXTURE_LUMINANCE_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RED_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture")]
		TextureRedSize = Gl.TEXTURE_RED_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RESIDENT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture_object")]
		[RemovedByFeature("GL_VERSION_3_2")]
		TextureResident = Gl.TEXTURE_RESIDENT,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_WIDTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		TextureWidth = Gl.TEXTURE_WIDTH,

	}

	/// <summary>
	/// Strongly typed enumeration TextureTarget.
	/// </summary>
	public enum TextureTarget
	{
		/// <summary>
		/// Strongly typed for value GL_DETAIL_TEXTURE_2D_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_detail_texture")]
		DetailTexture2dSgis = Gl.DETAIL_TEXTURE_2D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_1D, GL_PROXY_TEXTURE_1D_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		ProxyTexture1d = Gl.PROXY_TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_1D_ARRAY, GL_PROXY_TEXTURE_1D_ARRAY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_array")]
		ProxyTexture1dArray = Gl.PROXY_TEXTURE_1D_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_2D, GL_PROXY_TEXTURE_2D_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_EXT_texture")]
		ProxyTexture2d = Gl.PROXY_TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_2D_ARRAY, GL_PROXY_TEXTURE_2D_ARRAY_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_EXT_texture_array")]
		ProxyTexture2dArray = Gl.PROXY_TEXTURE_2D_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_2D_MULTISAMPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		ProxyTexture2dMultisample = Gl.PROXY_TEXTURE_2D_MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		ProxyTexture2dMultisampleArray = Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_3D, GL_PROXY_TEXTURE_3D_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		ProxyTexture3d = Gl.PROXY_TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_4D_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		ProxyTexture4dSgis = Gl.PROXY_TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_CUBE_MAP, GL_PROXY_TEXTURE_CUBE_MAP_ARB, GL_PROXY_TEXTURE_CUBE_MAP_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		ProxyTextureCubeMap = Gl.PROXY_TEXTURE_CUBE_MAP,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_CUBE_MAP_ARRAY, GL_PROXY_TEXTURE_CUBE_MAP_ARRAY_ARB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array", Api = "gl|glcore")]
		ProxyTextureCubeMapArray = Gl.PROXY_TEXTURE_CUBE_MAP_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_PROXY_TEXTURE_RECTANGLE, GL_PROXY_TEXTURE_RECTANGLE_ARB, GL_PROXY_TEXTURE_RECTANGLE_NV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		ProxyTextureRectangle = Gl.PROXY_TEXTURE_RECTANGLE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		Texture1d = Gl.TEXTURE_1D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		Texture2d = Gl.TEXTURE_2D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_3D, GL_TEXTURE_3D_EXT, GL_TEXTURE_3D_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture3D")]
		[RequiredByFeature("GL_OES_texture_3D", Api = "gles2")]
		Texture3d = Gl.TEXTURE_3D,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_4D_SGIS.
		/// </summary>
		[RequiredByFeature("GL_SGIS_texture4D")]
		Texture4dSgis = Gl.TEXTURE_4D_SGIS,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_RECTANGLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_rectangle")]
		[RequiredByFeature("GL_NV_texture_rectangle")]
		TextureRectangle = Gl.TEXTURE_RECTANGLE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMap = Gl.TEXTURE_CUBE_MAP,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_X.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapPositiveX = Gl.TEXTURE_CUBE_MAP_POSITIVE_X,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_X.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapNegativeX = Gl.TEXTURE_CUBE_MAP_NEGATIVE_X,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_Y.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapPositiveY = Gl.TEXTURE_CUBE_MAP_POSITIVE_Y,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_Y.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapNegativeY = Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_POSITIVE_Z.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapPositiveZ = Gl.TEXTURE_CUBE_MAP_POSITIVE_Z,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_cube_map")]
		[RequiredByFeature("GL_EXT_texture_cube_map")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		TextureCubeMapNegativeZ = Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_CUBE_MAP_ARRAY, GL_TEXTURE_CUBE_MAP_ARRAY_ARB, GL_TEXTURE_CUBE_MAP_ARRAY_EXT, 
		/// GL_TEXTURE_CUBE_MAP_ARRAY_OES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_cube_map_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_cube_map_array", Api = "gles2")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_cube_map_array", Api = "gles2")]
		TextureCubeMapArray = Gl.TEXTURE_CUBE_MAP_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_1D_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_array")]
		Texture1dArray = Gl.TEXTURE_1D_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_array")]
		Texture2dArray = Gl.TEXTURE_2D_ARRAY,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D_MULTISAMPLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		Texture2dMultisample = Gl.TEXTURE_2D_MULTISAMPLE,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE_2D_MULTISAMPLE_ARRAY.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_texture_multisample", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_internalformat_sample_query", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_OES_texture_storage_multisample_2d_array", Api = "gles2")]
		Texture2dMultisampleArray = Gl.TEXTURE_2D_MULTISAMPLE_ARRAY,

	}

	/// <summary>
	/// Strongly typed enumeration TextureUnit.
	/// </summary>
	public enum TextureUnit
	{
		/// <summary>
		/// Strongly typed for value GL_TEXTURE0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		Texture0 = Gl.TEXTURE0,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		[RequiredByFeature("GL_NV_register_combiners")]
		Texture1 = Gl.TEXTURE1,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture2 = Gl.TEXTURE2,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE3.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture3 = Gl.TEXTURE3,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture4 = Gl.TEXTURE4,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE5.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture5 = Gl.TEXTURE5,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE6.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture6 = Gl.TEXTURE6,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE7.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture7 = Gl.TEXTURE7,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE8.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture8 = Gl.TEXTURE8,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE9.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture9 = Gl.TEXTURE9,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE10.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture10 = Gl.TEXTURE10,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE11.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture11 = Gl.TEXTURE11,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE12.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture12 = Gl.TEXTURE12,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE13.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture13 = Gl.TEXTURE13,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE14.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture14 = Gl.TEXTURE14,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE15.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture15 = Gl.TEXTURE15,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE16.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture16 = Gl.TEXTURE16,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE17.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture17 = Gl.TEXTURE17,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE18.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture18 = Gl.TEXTURE18,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE19.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture19 = Gl.TEXTURE19,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE20.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture20 = Gl.TEXTURE20,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE21.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture21 = Gl.TEXTURE21,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE22.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture22 = Gl.TEXTURE22,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE23.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture23 = Gl.TEXTURE23,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE24.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture24 = Gl.TEXTURE24,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE25.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture25 = Gl.TEXTURE25,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE26.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture26 = Gl.TEXTURE26,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE27.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture27 = Gl.TEXTURE27,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE28.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture28 = Gl.TEXTURE28,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE29.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture29 = Gl.TEXTURE29,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE30.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture30 = Gl.TEXTURE30,

		/// <summary>
		/// Strongly typed for value GL_TEXTURE31.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_multitexture")]
		Texture31 = Gl.TEXTURE31,

	}

	/// <summary>
	/// Strongly typed enumeration TextureWrapMode.
	/// </summary>
	public enum TextureWrapMode
	{
		/// <summary>
		/// Strongly typed for value GL_CLAMP.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		Clamp = Gl.CLAMP,

		/// <summary>
		/// Strongly typed for value GL_CLAMP_TO_BORDER, GL_CLAMP_TO_BORDER_ARB, GL_CLAMP_TO_BORDER_NV, GL_CLAMP_TO_BORDER_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_3")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_border_clamp", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_SGIS_texture_border_clamp")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		ClampToBorder = Gl.CLAMP_TO_BORDER,

		/// <summary>
		/// Strongly typed for value GL_CLAMP_TO_EDGE, GL_CLAMP_TO_EDGE_SGIS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_SGIS_texture_edge_clamp")]
		ClampToEdge = Gl.CLAMP_TO_EDGE,

		/// <summary>
		/// Strongly typed for value GL_REPEAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Repeat = Gl.REPEAT,

	}

	/// <summary>
	/// Strongly typed enumeration TransformFeedbackPName.
	/// </summary>
	public enum TransformFeedbackPName
	{
		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_ACTIVE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		TransformFeedbackBufferActive = Gl.TRANSFORM_FEEDBACK_BUFFER_ACTIVE,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER_BINDING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackBufferBinding = Gl.TRANSFORM_FEEDBACK_BUFFER_BINDING,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER_START.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackBufferStart = Gl.TRANSFORM_FEEDBACK_BUFFER_START,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_BUFFER_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_transform_feedback")]
		[RequiredByFeature("GL_NV_transform_feedback")]
		TransformFeedbackBufferSize = Gl.TRANSFORM_FEEDBACK_BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK_PAUSED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_transform_feedback2", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		TransformFeedbackBufferPaused = Gl.TRANSFORM_FEEDBACK_BUFFER_PAUSED,

	}

	/// <summary>
	/// Strongly typed enumeration TransformFeedbackTarget.
	/// </summary>
	public enum TransformFeedbackTarget
	{
		/// <summary>
		/// Strongly typed for value GL_TRANSFORM_FEEDBACK.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_transform_feedback2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_debug_label", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_transform_feedback2")]
		TransformFeedback = Gl.TRANSFORM_FEEDBACK,

	}

	/// <summary>
	/// Strongly typed enumeration UniformBlockPName.
	/// </summary>
	public enum UniformBlockPName
	{
		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_ACTIVE_UNIFORMS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockActiveUniforms = Gl.UNIFORM_BLOCK_ACTIVE_UNIFORMS,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockActiveUniformIndices = Gl.UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_BINDING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockBinding = Gl.UNIFORM_BLOCK_BINDING,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_DATA_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockDataSize = Gl.UNIFORM_BLOCK_DATA_SIZE,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_NAME_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockNameLength = Gl.UNIFORM_BLOCK_NAME_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockReferencedByVertexShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		UniformBlockReferencedByTessControlShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		UniformBlockReferencedByTessEvaluationShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockReferencedByGeometryShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockReferencedByFragmentShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		UniformBlockReferencedByComputeShader = Gl.UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER,

	}

	/// <summary>
	/// Strongly typed enumeration UniformPName.
	/// </summary>
	public enum UniformPName
	{
		/// <summary>
		/// Strongly typed for value GL_UNIFORM_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformType = Gl.UNIFORM_TYPE,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformSize = Gl.UNIFORM_SIZE,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_NAME_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_shader_subroutine", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformNameLength = Gl.UNIFORM_NAME_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_BLOCK_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformBlockIndex = Gl.UNIFORM_BLOCK_INDEX,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_OFFSET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformOffset = Gl.UNIFORM_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformArrayStride = Gl.UNIFORM_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_MATRIX_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformMatrixStride = Gl.UNIFORM_MATRIX_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_IS_ROW_MAJOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_1")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_uniform_buffer_object", Api = "gl|glcore")]
		UniformIsRowMajor = Gl.UNIFORM_IS_ROW_MAJOR,

		/// <summary>
		/// Strongly typed for value GL_UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_2")]
		[RequiredByFeature("GL_ARB_shader_atomic_counters", Api = "gl|glcore")]
		UniformAtomicCounterBufferIndex = Gl.UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX,

	}

	/// <summary>
	/// Strongly typed enumeration UseProgramStageMask.
	/// </summary>
	[Flags()]
	public enum UseProgramStageMask : uint
	{
		/// <summary>
		/// Strongly typed for value GL_VERTEX_SHADER_BIT, GL_VERTEX_SHADER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		VertexShaderBit = Gl.VERTEX_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_FRAGMENT_SHADER_BIT, GL_FRAGMENT_SHADER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		FragmentShaderBit = Gl.FRAGMENT_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_GEOMETRY_SHADER_BIT, GL_GEOMETRY_SHADER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		GeometryShaderBit = Gl.GEOMETRY_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TESS_CONTROL_SHADER_BIT, GL_TESS_CONTROL_SHADER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessControlShaderBit = Gl.TESS_CONTROL_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_TESS_EVALUATION_SHADER_BIT, GL_TESS_EVALUATION_SHADER_BIT_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		TessEvaluationShaderBit = Gl.TESS_EVALUATION_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_COMPUTE_SHADER_BIT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_compute_shader", Api = "gl|glcore")]
		ComputeShaderBit = Gl.COMPUTE_SHADER_BIT,

		/// <summary>
		/// Strongly typed for value GL_ALL_SHADER_BITS, GL_ALL_SHADER_BITS_EXT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_separate_shader_objects", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_separate_shader_objects", Api = "gl|glcore|gles2")]
		AllShaderBits = Gl.ALL_SHADER_BITS,

	}

	/// <summary>
	/// Strongly typed enumeration VertexArrayPName.
	/// </summary>
	public enum VertexArrayPName
	{
		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_DIVISOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
		VertexAttribArrayDivisor = Gl.VERTEX_ATTRIB_ARRAY_DIVISOR,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_ENABLED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayEnabled = Gl.VERTEX_ATTRIB_ARRAY_ENABLED,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		VertexAttribArrayInteger = Gl.VERTEX_ATTRIB_ARRAY_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_LONG.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		VertexAttribArrayLong = Gl.VERTEX_ATTRIB_ARRAY_LONG,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_NORMALIZED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayNormalized = Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArraySize = Gl.VERTEX_ATTRIB_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayStride = Gl.VERTEX_ATTRIB_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayType = Gl.VERTEX_ATTRIB_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_RELATIVE_OFFSET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_attrib_binding", Api = "gl|glcore")]
		VertexAttribRelativeOffset = Gl.VERTEX_ATTRIB_RELATIVE_OFFSET,

	}

	/// <summary>
	/// Strongly typed enumeration VertexAttribPName.
	/// </summary>
	public enum VertexAttribPName
	{
		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_BUFFER_BINDING.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		VertexAttribArrayBufferBinding = Gl.VERTEX_ATTRIB_ARRAY_BUFFER_BINDING,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_ENABLED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayEnabled = Gl.VERTEX_ATTRIB_ARRAY_ENABLED,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArraySize = Gl.VERTEX_ATTRIB_ARRAY_SIZE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_STRIDE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayStride = Gl.VERTEX_ATTRIB_ARRAY_STRIDE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_TYPE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayType = Gl.VERTEX_ATTRIB_ARRAY_TYPE,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_NORMALIZED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		VertexAttribArrayNormalized = Gl.VERTEX_ATTRIB_ARRAY_NORMALIZED,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_INTEGER.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_gpu_shader4")]
		[RequiredByFeature("GL_NV_vertex_program4")]
		VertexAttribArrayInteger = Gl.VERTEX_ATTRIB_ARRAY_INTEGER,

		/// <summary>
		/// Strongly typed for value GL_VERTEX_ATTRIB_ARRAY_DIVISOR.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_ARB_instanced_arrays", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_instanced_arrays", Api = "gles2")]
		[RequiredByFeature("GL_NV_instanced_arrays", Api = "gles2")]
		VertexAttribArrayDivisor = Gl.VERTEX_ATTRIB_ARRAY_DIVISOR,

		/// <summary>
		/// Strongly typed for value GL_CURRENT_VERTEX_ATTRIB.
		/// </summary>
		[RequiredByFeature("GL_VERSION_2_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_program")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		CurrentVertexAttrib = Gl.CURRENT_VERTEX_ATTRIB,

	}

	/// <summary>
	/// Strongly typed enumeration VertexAttribType.
	/// </summary>
	public enum VertexAttribType
	{
		/// <summary>
		/// Strongly typed for value GL_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		Byte = Gl.BYTE,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_BYTE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		UnsignedByte = Gl.UNSIGNED_BYTE,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		UnsignedShort = Gl.UNSIGNED_SHORT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		UnsignedInt = Gl.UNSIGNED_INT,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_HALF_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_half_float_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_half_float_pixel")]
		[RequiredByFeature("GL_NV_half_float")]
		HalfFloat = Gl.HALF_FLOAT,

		/// <summary>
		/// Strongly typed for value GL_FIXED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_1")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES2_compatibility", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_fixed_point", Api = "gl|gles1")]
		Fixed = Gl.FIXED,

		/// <summary>
		/// Strongly typed for value GL_INT_2_10_10_10_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_3")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		Int2101010Rev = Gl.INT_2_10_10_10_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_2_10_10_10_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_2")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_2_10_10_10_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_texture_type_2_10_10_10_REV", Api = "gles2")]
		UnsignedInt2101010Rev = Gl.UNSIGNED_INT_2_10_10_10_REV,

		/// <summary>
		/// Strongly typed for value GL_UNSIGNED_INT_10F_11F_11F_REV.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_type_10f_11f_11f_rev", Api = "gl|glcore")]
		[RequiredByFeature("GL_APPLE_texture_packed_float", Api = "gles2")]
		[RequiredByFeature("GL_EXT_packed_float")]
		UnsignedInt10f11f11fRev = Gl.UNSIGNED_INT_10F_11F_11F_REV,

	}

	/// <summary>
	/// Strongly typed enumeration VertexBufferObjectParameter.
	/// </summary>
	public enum VertexBufferObjectParameter
	{
		/// <summary>
		/// Strongly typed for value GL_BUFFER_ACCESS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		BufferAccess = Gl.BUFFER_ACCESS,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_ACCESS_FLAGS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		BufferAccessFlags = Gl.BUFFER_ACCESS_FLAGS,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_IMMUTABLE_STORAGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		BufferImmutableStorage = Gl.BUFFER_IMMUTABLE_STORAGE,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_MAPPED.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		[RequiredByFeature("GL_OES_mapbuffer", Api = "gles1|gles2")]
		BufferMapped = Gl.BUFFER_MAPPED,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_MAP_LENGTH.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		BufferMapLength = Gl.BUFFER_MAP_LENGTH,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_MAP_OFFSET.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		BufferMapOffset = Gl.BUFFER_MAP_OFFSET,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_SIZE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		BufferSize = Gl.BUFFER_SIZE,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_STORAGE_FLAGS.
		/// </summary>
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ARB_buffer_storage", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_buffer_storage", Api = "gles2")]
		BufferStorageFlags = Gl.BUFFER_STORAGE_FLAGS,

		/// <summary>
		/// Strongly typed for value GL_BUFFER_USAGE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_buffer_object")]
		BufferUsage = Gl.BUFFER_USAGE,

	}

	/// <summary>
	/// Strongly typed enumeration VertexProvokingMode.
	/// </summary>
	public enum VertexProvokingMode
	{
		/// <summary>
		/// Strongly typed for value GL_FIRST_VERTEX_CONVENTION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		FirstVertexConvention = Gl.FIRST_VERTEX_CONVENTION,

		/// <summary>
		/// Strongly typed for value GL_LAST_VERTEX_CONVENTION.
		/// </summary>
		[RequiredByFeature("GL_VERSION_3_2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_provoking_vertex", Api = "gl|glcore")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_geometry_shader", Api = "gles2")]
		[RequiredByFeature("GL_EXT_provoking_vertex")]
		[RequiredByFeature("GL_OES_geometry_shader", Api = "gles2")]
		LastVertexConvention = Gl.LAST_VERTEX_CONVENTION,

	}

	/// <summary>
	/// Strongly typed enumeration VertexPointerType.
	/// </summary>
	public enum VertexPointerType
	{
		/// <summary>
		/// Strongly typed for value GL_DOUBLE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_1")]
		[RequiredByFeature("GL_ARB_gpu_shader_fp64", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_vertex_attrib_64bit")]
		Double = Gl.DOUBLE,

		/// <summary>
		/// Strongly typed for value GL_FLOAT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		Float = Gl.FLOAT,

		/// <summary>
		/// Strongly typed for value GL_INT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		Int = Gl.INT,

		/// <summary>
		/// Strongly typed for value GL_SHORT.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_SC_VERSION_2_0", Api = "glsc2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		Short = Gl.SHORT,

	}

}
