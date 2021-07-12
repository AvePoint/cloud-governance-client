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
export enum TreeNodeType {
    Root = 0,
    WebApplication = 2,
    Tenant = 3,
    Container = 4,
    ManagedPath = 10,
    SiteCollection = 100,
    Site = 200,
    Sites = 201,
    Lists = 202,
    List = 300,
    DocumentLibrary = 310,
    Folder = 400,
    Folders = 401,
    Items = 402,
    Item = 500,
    File = 501,
    Team = 598,
    Yammer = 599,
    Group = 600,
    GuestUser = 601,
    All = 1000,
    WebApplication_D = -5,
    BPOSDCA = -4,
    SelectAll = -3,
    None = -2,
    Farm = -1
}

export function TreeNodeTypeFromJSON(json: any): TreeNodeType {
    return TreeNodeTypeFromJSONTyped(json, false);
}

export function TreeNodeTypeFromJSONTyped(json: any, ignoreDiscriminator: boolean): TreeNodeType {
    return json as TreeNodeType;
}

export function TreeNodeTypeToJSON(value?: TreeNodeType | null): any {
    return value as any;
}

