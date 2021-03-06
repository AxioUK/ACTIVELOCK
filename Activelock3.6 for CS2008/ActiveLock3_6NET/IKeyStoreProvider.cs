using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
 // ERROR: Not supported in C#: OptionDeclaration
interface _IKeyStoreProvider
{
	string KeyStorePath {
		set;
	}
	ProductLicense Retrieve(ref string ProductName, IActiveLock.ALLicenseFileTypes mLicenseFileType);
	void Store(ref ProductLicense Lic, IActiveLock.ALLicenseFileTypes mLicenseFileType);
}
internal class IKeyStoreProvider : _IKeyStoreProvider
{
	//*   ActiveLock
	//*   Copyright 1998-2002 Nelson Ferraz
	//*   Copyright 2006 The ActiveLock Software Group (ASG)
	//*   All material is the property of the contributing authors.
	//*
	//*   Redistribution and use in source and binary forms, with or without
	//*   modification, are permitted provided that the following conditions are
	//*   met:
	//*
	//*     [o] Redistributions of source code must retain the above copyright
	//*         notice, this list of conditions and the following disclaimer.
	//*
	//*     [o] Redistributions in binary form must reproduce the above
	//*         copyright notice, this list of conditions and the following
	//*         disclaimer in the documentation and/or other materials provided
	//*         with the distribution.
	//*
	//*   THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
	//*   "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
	//*   LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
	//*   A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT
	//*   OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
	//*   SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
	//*   LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
	//*   DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
	//*   THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
	//*   (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
	//*   OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
	//*
	//*
	//===============================================================================
	// Name: IKeyStoreProvider
	// Purpose: This is the interface for a class that facilitates storing and
	// retrieving of product license keys.
	// Functions:
	// Properties:
	// Methods:
	// Started: 21.04.2005
	// Modified: 03.24.2006
	//===============================================================================
	// @author activelock-admins
	// @version 3.3.0
	// @date 03.24.2006
	//
	//===============================================================================
	// Name: Property Let KeyStorePath
	// Input:
	//   ByRef path As String - Key store path
	// Output: None
	// Purpose: Specifies the path under which the keys are stored.
	// Remarks: Example: path to a license file, or path to the Windows Registry hive
	//===============================================================================
	public string KeyStorePath {

		set { }
	}
	//===============================================================================
	// Name: Function Retrieve
	// Input:
	//   ByRef ProductName As String - Product Name
	// Output:
	//   ProductLicense - ProductLicense object matching the specified product name.
	//   If no license found, then <code>Nothing</code> is returned.
	// Purpose: Retrieves license info for the specified product name.
	// Remarks: None
	//===============================================================================
	public ProductLicense Retrieve(ref string ProductName, IActiveLock.ALLicenseFileTypes mLicenseFileType)
	{
		return null;
	}

	//===============================================================================
	// Name: Sub Store
	// Input:
	//   ByRef Lic As ProductLicense - Product license
	// Output: None
	// Purpose: Stores a license.
	// Remarks: None
	//===============================================================================

	public void Store(ref ProductLicense Lic, IActiveLock.ALLicenseFileTypes mLicenseFileType)
	{
	}
}
