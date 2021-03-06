﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeApp.Utilities
{
    // ReSharper disable InconsistentNaming
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public partial interface IAppBindings
    {
        Task<List<ContainerPermissions>> AccessContainerFetchAsync(IntPtr app);

        Task<MDataInfo> AccessContainerGetContainerMDataInfoAsync(IntPtr app, string name);

        Task AccessContainerRefreshAccessInfoAsync(IntPtr app);

        Task<AccountInfo> AppAccountInfoAsync(IntPtr app);

        Task<string> AppContainerNameAsync(string appId);

        Task<string> AppExeFileStemAsync();

        void AppFree(IntPtr app);

        Task AppInitLoggingAsync(string outputFileNameOverride);

        Task<string> AppOutputLogPathAsync(string outputFileName);

        Task<ulong> AppPubEncKeyAsync(IntPtr app);

        Task<ulong> AppPubSignKeyAsync(IntPtr app);

        Task AppReconnectAsync(IntPtr app);

        Task AppResetObjectCacheAsync(IntPtr app);

        Task AppSetAdditionalSearchPathAsync(string newPath);

        Task CipherOptFreeAsync(IntPtr app, ulong handle);

        Task<ulong> CipherOptNewAsymmetricAsync(IntPtr app, ulong peerEncryptKeyH);

        Task<ulong> CipherOptNewPlaintextAsync(IntPtr app);

        Task<ulong> CipherOptNewSymmetricAsync(IntPtr app);

        Task<List<byte>> DecryptAsync(IntPtr app, List<byte> data, ulong publicKeyH, ulong secretKeyH);

        Task<List<byte>> DecryptSealedBoxAsync(IntPtr app, List<byte> data, ulong publicKeyH, ulong secretKeyH);

        Task<ulong> DirDeleteFileAsync(IntPtr app, ref MDataInfo parentInfo, string fileName, ulong version);

        Task<(File, ulong)> DirFetchFileAsync(IntPtr app, ref MDataInfo parentInfo, string fileName);

        Task DirInsertFileAsync(IntPtr app, ref MDataInfo parentInfo, string fileName, ref File file);

        Task<ulong> DirUpdateFileAsync(IntPtr app, ref MDataInfo parentInfo, string fileName, ref File file, ulong version);

        Task<(ulong, ulong)> EncGenerateKeyPairAsync(IntPtr app);

        Task<(uint, string)> EncodeAuthReqAsync(ref AuthReq req);

        Task<(uint, string)> EncodeContainersReqAsync(ref ContainersReq req);

        Task<(uint, string)> EncodeShareMDataReqAsync(ref ShareMDataReq req);

        Task<(uint, string)> EncodeUnregisteredReqAsync(List<byte> extraData);

        Task EncPubKeyFreeAsync(IntPtr app, ulong handle);

        Task<byte[]> EncPubKeyGetAsync(IntPtr app, ulong handle);

        Task<ulong> EncPubKeyNewAsync(IntPtr app, byte[] data);

        Task<List<byte>> EncryptAsync(IntPtr app, List<byte> data, ulong publicKeyH, ulong secretKeyH);

        Task<List<byte>> EncryptSealedBoxAsync(IntPtr app, List<byte> data, ulong publicKeyH);

        Task EncSecretKeyFreeAsync(IntPtr app, ulong handle);

        Task<byte[]> EncSecretKeyGetAsync(IntPtr app, ulong handle);

        Task<ulong> EncSecretKeyNewAsync(IntPtr app, byte[] data);

        Task<File> FileCloseAsync(IntPtr app, ulong fileH);

        Task<ulong> FileOpenAsync(IntPtr app, ref MDataInfo parentInfo, ref File file, ulong openMode);

        Task<List<byte>> FileReadAsync(IntPtr app, ulong fileH, ulong position, ulong len);

        Task<ulong> FileSizeAsync(IntPtr app, ulong fileH);

        Task FileWriteAsync(IntPtr app, ulong fileH, List<byte> data);

        Task<byte[]> GenerateNonceAsync();

        Task<byte[]> IDataCloseSelfEncryptorAsync(IntPtr app, ulong seH, ulong cipherOptH);

        Task<ulong> IDataFetchSelfEncryptorAsync(IntPtr app, byte[] name);

        Task<ulong> IDataNewSelfEncryptorAsync(IntPtr app);

        Task<List<byte>> IDataReadFromSelfEncryptorAsync(IntPtr app, ulong seH, ulong fromPos, ulong len);

        Task IDataSelfEncryptorReaderFreeAsync(IntPtr app, ulong handle);

        Task IDataSelfEncryptorWriterFreeAsync(IntPtr app, ulong handle);

        Task<ulong> IDataSerialisedSizeAsync(IntPtr app, byte[] name);

        Task<ulong> IDataSizeAsync(IntPtr app, ulong seH);

        Task IDataWriteToSelfEncryptorAsync(IntPtr app, ulong seH, List<byte> data);

        bool IsMockBuild();

        Task MDataDelUserPermissionsAsync(IntPtr app, ref MDataInfo info, ulong userH, ulong version);

        Task<List<byte>> MDataEncodeMetadataAsync(ref MetadataResponse metadata);

        Task<ulong> MDataEntriesAsync(IntPtr app, ref MDataInfo info);

        Task MDataEntriesFreeAsync(IntPtr app, ulong entriesH);

        Task<(List<byte>, ulong)> MDataEntriesGetAsync(IntPtr app, ulong entriesH, List<byte> key);

        Task MDataEntriesInsertAsync(IntPtr app, ulong entriesH, List<byte> key, List<byte> value);

        Task<ulong> MDataEntriesLenAsync(IntPtr app, ulong entriesH);

        Task<ulong> MDataEntriesNewAsync(IntPtr app);

        Task MDataEntryActionsDeleteAsync(IntPtr app, ulong actionsH, List<byte> key, ulong entryVersion);

        Task MDataEntryActionsFreeAsync(IntPtr app, ulong actionsH);

        Task MDataEntryActionsInsertAsync(IntPtr app, ulong actionsH, List<byte> key, List<byte> value);

        Task<ulong> MDataEntryActionsNewAsync(IntPtr app);

        Task MDataEntryActionsUpdateAsync(IntPtr app, ulong actionsH, List<byte> key, List<byte> value, ulong entryVersion);

        Task<(List<byte>, ulong)> MDataGetValueAsync(IntPtr app, ref MDataInfo info, List<byte> key);

        Task<ulong> MDataGetVersionAsync(IntPtr app, ref MDataInfo info);

        Task<List<byte>> MDataInfoDecryptAsync(ref MDataInfo info, List<byte> input);

        Task<MDataInfo> MDataInfoDeserialiseAsync(List<byte> encoded);

        Task<List<byte>> MDataInfoEncryptEntryKeyAsync(ref MDataInfo info, List<byte> input);

        Task<List<byte>> MDataInfoEncryptEntryValueAsync(ref MDataInfo info, List<byte> input);

        Task<MDataInfo> MDataInfoNewPrivateAsync(byte[] name, ulong typeTag, byte[] secretKey, byte[] nonce);

        Task<MDataInfo> MDataInfoRandomPrivateAsync(ulong typeTag);

        Task<MDataInfo> MDataInfoRandomPublicAsync(ulong typeTag);

        Task<List<byte>> MDataInfoSerialiseAsync(ref MDataInfo info);

        Task<List<MDataEntry>> MDataListEntriesAsync(IntPtr app, ulong entriesH);

        Task<List<MDataKey>> MDataListKeysAsync(IntPtr app, ref MDataInfo info);

        Task<ulong> MDataListPermissionsAsync(IntPtr app, ref MDataInfo info);

        Task<List<UserPermissionSet>> MDataListPermissionSetsAsync(IntPtr app, ulong permissionsH);

        Task<PermissionSet> MDataListUserPermissionsAsync(IntPtr app, ref MDataInfo info, ulong userH);

        Task<List<MDataValue>> MDataListValuesAsync(IntPtr app, ref MDataInfo info);

        Task MDataMutateEntriesAsync(IntPtr app, ref MDataInfo info, ulong actionsH);

        Task MDataPermissionsFreeAsync(IntPtr app, ulong permissionsH);

        Task<PermissionSet> MDataPermissionsGetAsync(IntPtr app, ulong permissionsH, ulong userH);

        Task MDataPermissionsInsertAsync(IntPtr app, ulong permissionsH, ulong userH, ref PermissionSet permissionSet);

        Task<ulong> MDataPermissionsLenAsync(IntPtr app, ulong permissionsH);

        Task<ulong> MDataPermissionsNewAsync(IntPtr app);

        Task MDataPutAsync(IntPtr app, ref MDataInfo info, ulong permissionsH, ulong entriesH);

        Task<ulong> MDataSerialisedSizeAsync(IntPtr app, ref MDataInfo info);

        Task MDataSetUserPermissionsAsync(IntPtr app, ref MDataInfo info, ulong userH, ref PermissionSet permissionSet, ulong version);

        Task<List<byte>> Sha3HashAsync(List<byte> data);

        Task<List<byte>> SignAsync(IntPtr app, List<byte> data, ulong signSkH);

        Task<(ulong, ulong)> SignGenerateKeyPairAsync(IntPtr app);

        Task SignPubKeyFreeAsync(IntPtr app, ulong handle);

        Task<byte[]> SignPubKeyGetAsync(IntPtr app, ulong handle);

        Task<ulong> SignPubKeyNewAsync(IntPtr app, byte[] data);

        Task SignSecKeyFreeAsync(IntPtr app, ulong handle);

        Task<byte[]> SignSecKeyGetAsync(IntPtr app, ulong handle);

        Task<ulong> SignSecKeyNewAsync(IntPtr app, byte[] data);

        Task<List<byte>> VerifyAsync(IntPtr app, List<byte> signedData, ulong signPkH);
    }
}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
