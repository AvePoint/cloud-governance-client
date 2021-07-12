/* tslint:disable */
/* eslint-disable */
/*
 * Cloud Governance Api
 *
 * Contact: support@avepoint.com
 */

/**
 * 
 * @export
 * @enum {string}
 */
export enum MessageCode {
    None = 0,
    NoServicePermission = 1,
    SiteNotInScope = 300,
    SiteUnlock = 301,
    SiteNotInGADB = 302,
    SiteInvalid = 303,
    SiteLifecycleLock = 304,
    SiteAutoLifecycleLock = 305,
    SiteHasPendingRenewal = 306,
    SiteHasRecertification = 307,
    SitePolicyInvalid = 308,
    SiteExtendTimeError = 309,
    SiteLocked = 310,
    GroupArchived = 400,
    GroupNotInGADB = 401,
    TeamArchiveAvaliable = 402,
    TeamRestoreAvaliable = 403,
    TeamArchivedNotRestore = 404,
    GroupNotInScope = 405,
    TeamNotInScope = 406,
    GroupDisableDelete = 407,
    GroupDisableExtend = 408,
    GroupDisableChangePolicy = 409,
    GroupDisableChangeQuota = 410,
    GroupDisableArchive = 411,
    GroupDisableUnArchive = 412,
    GroupNotInServiceScope = 413,
    GroupNotAllowAddGuestUser = 414,
    YammerNotInScope = 415,
    YammerNotSupportedArchive = 416,
    GroupRestrictAccess = 417,
    CreateGuestUserEmailExist = 500,
    CreateGuestUserEmailVerified = 501,
    ListTitleExist = 600,
    GroupDisableLease = 700
}

export function MessageCodeFromJSON(json: any): MessageCode {
    return MessageCodeFromJSONTyped(json, false);
}

export function MessageCodeFromJSONTyped(json: any, ignoreDiscriminator: boolean): MessageCode {
    return json as MessageCode;
}

export function MessageCodeToJSON(value?: MessageCode | null): any {
    return value as any;
}

